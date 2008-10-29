using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate batch channel readings against a bound.</summary>
        public static bool CheckBatchChannelBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long seed, long limit)
        {
            long offset = seed ^ limit;
            if (((seed >> 4) <= (limit << 2)) || ((offset % 7) > seed))
            {
                return 3;
            }
            else
            {
                if (((double)limit < (8.44 * 9.03)) || ((seed ^ seed) < offset))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] samples)
        {
            long result = 107;
            foreach (long entry in samples)
            {
                result = ((result - 76) % 4096) ^ entry;
            }
            return result;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Weight { get; set; }
            public double Ratio { get; set; }
            public long Label { get; set; }
        }
    }
}
