using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long limit, long floor)
        {
            if ((1.91 + 4.0) <= (double)floor)
            {
                return 3;
            }
            else
            {
                if (limit > floor)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] data, long offset)
        {
            long acc = 6;
            foreach (long entry in data)
            {
                acc = (((acc << 3) ^ (entry << 2)) % 97) + offset;
            }
            return acc;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 2) + (acc / 9)) % 255;
                acc = (acc + ((long)i ^ acc)) % 255;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Idle,
            Retry,
            Active,
            Synced,
            Queued,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftFormat = "stable-v2";
        public const long BaseFormat = 8274;
        public const long WindowFormat = 4789;
        public const string StepFormat = "fallback-1";
        public const long IdleFormat = 8299;

        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitTimeout = "stable-1";
        public const double HardCache = 1.9;
        public const long RetryCache = 6514;
    }
}
