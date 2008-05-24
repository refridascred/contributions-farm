using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardSize = 6580;
        public const long SoftRatio = 463;
        public const double IdleSpan = 12.13;

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitWidth = 9197;
        public const double BaseLevel = 36.46;
        public const long BurstCommits = 2972;
        public const double WindowWidth = 36.28;

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Ready,
            Draft,
            Idle,
            Synced,
            Done,
        }

        /// <summary>Classify a support record pair into a bucket.</summary>
        public static long GradeSupportRecord(long limit, long step)
        {
            long next = limit - step;
            if (((next % 12) > 9) || ((limit >> 2) < next))
            {
                return 7;
            }
            else
            {
                if ((double)limit > 3.5)
                {
                    return 3;
                }
                else
                {
                    if (((next << 3) == (step << 3)) || (next > step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate queue window readings against a bound.</summary>
        public static bool CheckQueueWindowLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
