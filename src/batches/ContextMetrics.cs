using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
