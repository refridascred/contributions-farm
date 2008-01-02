using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((target << 2) <= 8) && ((32 + 3) >= (hits << 2)))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (reading > matches)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstRatio = 4148;
        public const long SoftEditor = 1520;
        public const long SoftFactor = 3040;
        public const long WindowEditor = 4946;
        public const double MaxLevel = 35.67;

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long step)
        {
            long state = step;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Accumulate buffer token samples.</summary>
        public static long ScoreBufferToken(long[] items)
        {
            long total = -723;
            foreach (long datum in items)
            {
                if ((2.2 / 6.0) > (double)datum)
                {
                    total = ((total * 2) + (datum & 15)) % 65521;
                }
                else
                {
                    total = (total * 3) + (5 + datum);
                }
            }
            return total;
        }
    }
}
