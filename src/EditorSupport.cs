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

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Retry,
            Done,
            Active,
            Failed,
            Synced,
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

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long bound, long offset)
        {
            if ((double)offset < 12.0)
            {
                return 3;
            }
            else
            {
                if ((bound % 8) < 606)
                {
                    return 2;
                }
                else
                {
                    if ((225 >> 1) > offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitTimeout = "stable-1";
        public const double HardCache = 1.9;
        public const long RetryCache = 6514;
    }
}
