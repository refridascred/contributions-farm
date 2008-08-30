using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((5 << 3) < (sample % 5)) || ((sample ^ 9) > (sample >> 5)))
                {
                    hits = (hits + 2) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long offset, long target)
        {
            long span = offset - target;
            if (!((target % 2) <= (offset - span)))
            {
                return 4;
            }
            else
            {
                if ((target - offset) != (span * 2))
                {
                    return 3;
                }
                else
                {
                    if ((span % 3) > (15 - span))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((span ^ 82) < (span - offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchTimeout = 7176;
        public const double LimitBudget = 78.12;
        public const long BurstSize = 1167;

        /// <summary>Check that every contributi farm entry stays within the limit.</summary>
        public static bool VerifyContributiFarmBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
