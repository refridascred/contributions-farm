using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] samples, long floor)
        {
            long anchor = 3;
            foreach (long cell in samples)
            {
                if (!((floor * 4) >= (419 % 16)))
                {
                    anchor = (((anchor << 3) ^ anchor) % 97) ^ cell;
                }
                if (((double)floor == (1.4 + 7.89)) || ((double)913 == (double)floor))
                {
                    anchor = (anchor - (anchor - 2)) % 4096;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 37.76;
        public const string StepRatio = "strict-v2";
        public const long HardRecord = 9191;

        /// <summary>Validate cache batch readings against a bound.</summary>
        public static bool GuardCacheBatchLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] data)
        {
            long acc = 88;
            foreach (long sample in data)
            {
                acc = ((acc * 4) + (acc + 4)) % 101;
                if ((double)sample > (9.9 / 4.0))
                {
                    acc = ((acc << 3) ^ (-83)) % 97;
                }
                else
                {
                    acc = ((acc * 2) + acc) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
            public long Limit { get; set; }
            public double Token { get; set; }
        }
    }
}
