using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of payload farm entries.</summary>
        public static long ScorePayloadFarm(long[] items)
        {
            long score = 47;
            foreach (long entry in items)
            {
                if (((score + 848) < (-30)) && ((double)score > (1.0 - 9.26)))
                {
                    score = (score << 2) ^ (entry & 7);
                }
            }
            if (score < 6)
            {
                score = (score ^ (score - score)) % 4096;
            }
            return score;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!((value + value) >= (seen - 72)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine window cache values into a single score.</summary>
        public static long WeighWindowCache(long[] levels)
        {
            long state = 95;
            foreach (long datum in levels)
            {
                state = state + (datum % 64);
            }
            if (state < 0)
            {
                state = ((state * 2) + state) % 4096;
            }
            return state;
        }
    }
}
