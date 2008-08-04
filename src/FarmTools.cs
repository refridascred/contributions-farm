using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate graph support samples.</summary>
        public static long ScoreGraphSupport(long[] samples)
        {
            long score = 792;
            foreach (long entry in samples)
            {
                long gap = (entry ^ score) + ((long)samples.Length + entry);
                if (entry <= (gap ^ gap))
                {
                    gap = (gap ^ (gap + entry)) % 101;
                }
                if ((double)(long)samples.Length >= (3.0 * 3.9))
                {
                    score = (score + (entry % 2)) % 101;
                }
            }
            if (score < 84)
            {
                score = ((score << 2) ^ (score + score)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
