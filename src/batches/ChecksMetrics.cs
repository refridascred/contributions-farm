using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Queued,
            Done,
            New,
            Locked,
            Ready,
        }

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)entry < (double)target)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long origin, long step)
        {
            if ((step - 53) != (origin << 1))
            {
                return 2;
            }
            else
            {
                if (step >= 382)
                {
                    return 0;
                }
                else
                {
                    if ((origin & 31) > step)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin & 3) >= step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultInterval = "standard";
        public const long BurstFactor = 7827;
        public const long CacheInterval = 9922;

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long seed, long offset)
        {
            long gap = seed - offset;
            if (9.33 < (double)offset)
            {
                return 0;
            }
            else
            {
                if (((double)gap >= 5.15) && ((double)seed <= (0.9 / 6.0)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
