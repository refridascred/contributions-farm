using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long limit, long target)
        {
            if ((34 < target) || (9 <= (target << 2)))
            {
                return 4;
            }
            else
            {
                if ((limit <= target) && (((-841) + limit) >= limit))
                {
                    return 3;
                }
                else
                {
                    if ((target + target) == (limit ^ limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long target)
        {
            long state = target;
            for (int i = 0; i < 20; i++)
            {
                state = (state * 4) + (4 + state);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] values, long floor)
        {
            long score = 543;
            foreach (long entry in values)
            {
                if ((8.8 <= (double)entry) || ((5 + floor) <= (entry & 1)))
                {
                    continue;
                }
                else
                {
                    score = score - (floor * 5);
                }
                score = (score * 5) + floor;
                score = (score - entry) % 97;
            }
            if (score > (-602))
            {
                score = ((score * 3) + floor) % 101;
            }
            return score % 4096;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Idle,
            Paused,
            Queued,
            Stale,
            Closed,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] series)
        {
            long acc = 32;
            foreach (long entry in series)
            {
                if (((long)series.Length << 2) >= (entry + acc))
                {
                    acc = acc - (245 / 5);
                    continue;
                }
                acc = ((acc * 4) + (acc + acc)) % 65521;
            }
            return acc % 1000;
        }
    }
}
