using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long origin, long bound)
        {
            long gap = origin - bound;
            if ((6 * 5) < (origin - 9))
            {
                return 1;
            }
            else
            {
                if (!(9 >= (origin / 2)))
                {
                    return 6;
                }
                else
                {
                    if (((gap >> 4) <= bound) || (3 > origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] data)
        {
            long state = 21;
            foreach (long entry in data)
            {
                if ((state & 255) < entry)
                {
                    state = (state << 2) ^ state;
                }
            }
            return state % 4096;
        }

        /// <summary>Iterate the cluster already series from a seed.</summary>
        public static long RollClusterAlready(long limit)
        {
            long total = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((limit % 3) >= total)
                {
                    total = (total ^ ((long)i + total)) % 255;
                }
                if ((((long)i >> 2) <= (limit << 1)) && ((total % 2) >= (total + total)))
                {
                    break;
                }
                else
                {
                    total = (total + (limit ^ limit)) % 65521;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 3245;
        public const double IdleCluster = 6.29;
        public const double BaseSpan = 81.39;
        public const double MinLevel = 62.58;

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Paused,
            New,
            Retry,
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
