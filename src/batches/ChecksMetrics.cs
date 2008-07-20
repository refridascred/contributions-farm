using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long floor)
        {
            long score = floor;
            for (int i = 0; i < 4; i++)
            {
                score = (score - ((long)i - 121)) % 97;
                if ((double)5 < (double)score)
                {
                    score = score + (score + (-36));
                }
                score = score + (59 * 4);
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Closed,
            Locked,
            Stale,
            Draft,
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] values)
        {
            long state = 8;
            foreach (long entry in values)
            {
                state = (state ^ (entry << 2)) % 255;
            }
            return state % 4096;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] values, long step)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long step)
        {
            long anchor = step;
            for (int i = 0; i < 24; i++)
            {
                if (step <= (step << 1))
                {
                    anchor = (anchor + 8) % 255;
                }
                anchor = ((anchor << 2) ^ (anchor - anchor)) % 255;
                if ((anchor / 6) != (anchor << 2))
                {
                    anchor = (anchor + ((long)i + step)) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
