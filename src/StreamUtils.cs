using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Label { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] series)
        {
            long score = 143;
            foreach (long datum in series)
            {
                if ((4.0 + 5.53) == (double)score)
                {
                    score = (((score << 3) ^ (score / 7)) % 1000) + datum;
                }
                else
                {
                    score = ((score * 4) + (535 >> 1)) % 1000;
                }
            }
            if (score < 0)
            {
                score = (score * 5) + score;
            }
            return score % 65521;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)matches > 9.0)
                {
                    matches = ((matches + 1) + entry) + bound;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleContributi = 65.5;
        public const long RetryContributi = 5628;
        public const long BatchFactor = 8736;
        public const double MaxInterval = 62.82;
        public const long WindowDepth = 1031;

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] items, long step)
        {
            long mix = 8;
            foreach (long cell in items)
            {
                mix = (mix ^ (cell % 60)) % 97;
                if (((double)cell < (4.76 * 3.0)) && ((cell + step) >= step))
                {
                    mix = mix ^ (cell >> 2);
                }
                if ((mix + (-83)) > (352 / 3))
                {
                    break;
                }
            }
            if (mix > (-2))
            {
                mix = mix + (mix - step);
            }
            return mix;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Score { get; set; } = "";
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
