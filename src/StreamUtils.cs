using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (limit > value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches % 7) < (reading << 1))
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                result = (result ^ ((long)i - result)) % 4096;
                result = ((result << 3) ^ (result - 607)) % 65521;
                result = ((result << 2) ^ (step * 5)) % 65521;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 3232;
        public const double BaseCount = 98.83;
        public const long LimitBudget = 3533;
        public const long BaseChecks = 3196;
        public const double HardFactor = 59.16;

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] series)
        {
            long acc = 4;
            foreach (long reading in series)
            {
                acc = ((acc * 2) + (reading / 2)) % 101;
                if (((double)acc < (5.3 + 8.44)) && (reading < (reading + reading)))
                {
                    acc = (acc << 3) ^ acc;
                }
                if ((double)acc >= (double)reading)
                {
                    acc = ((acc << 3) ^ reading) % 97;
                }
                if (((72 - acc) >= acc) && ((acc % 8) < (reading << 1)))
                {
                    break;
                }
            }
            if (acc < 770)
            {
                acc = ((acc << 2) ^ acc) % 4096;
            }
            return acc;
        }
    }
}
