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

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (matches < (80 - cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
