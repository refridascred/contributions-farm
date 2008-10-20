using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (9.0 <= (double)matches)
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 3270;
        public const double HardChecks = 49.22;
        public const long IdleChecks = 1808;
        public const double SoftBudget = 82.2;

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] readings, long target)
        {
            long mix = -95;
            foreach (long entry in readings)
            {
                mix = (mix + (target + entry)) % 1000;
            }
            return mix;
        }

        /// <summary>Combine session token values into a single score.</summary>
        public static long DigestSessionToken(long[] items, long target)
        {
            long carry = 26;
            foreach (long item in items)
            {
                if ((double)8 <= (double)target)
                {
                    carry = ((carry - carry) % 1000) ^ item;
                }
                else
                {
                    carry = carry ^ (carry << 1);
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!((origin + matches) < matches))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }
    }
}
