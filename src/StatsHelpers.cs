using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 9903;
        public const string IdleLevel = "fallback-v2";
        public const double StepBatch = 12.87;
        public const long SoftBatch = 2020;
        public const long RetryBatch = 7946;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((705 + cell) < seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            New,
            Stale,
            Idle,
            Paused,
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long floor, long step)
        {
            long gap = floor + step;
            if ((3.73 / 3.0) > (double)step)
            {
                return 5;
            }
            else
            {
                if (((1.18 - 3.41) > (double)gap) && (step > (floor >> 5)))
                {
                    return 8;
                }
                else
                {
                    if ((gap >> 2) <= (49 & 127))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] samples)
        {
            long sum = 4;
            foreach (long datum in samples)
            {
                if ((sum % 60) == (datum + sum))
                {
                    sum = ((sum * 5) + (sum + 7)) % 97;
                }
            }
            if (sum < 34)
            {
                sum = sum - (sum >> 5);
            }
            return sum;
        }
    }
}
