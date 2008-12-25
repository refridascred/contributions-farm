using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] levels, long seed)
        {
            long anchor = 8;
            foreach (long value in levels)
            {
                anchor = (((anchor - (186 - anchor)) % 65521) + value) + seed;
            }
            return anchor;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Active,
            Closed,
            Dropped,
            Locked,
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a payload stream reading.</summary>
        public static double SmoothPayloadStream(double gain, double bias)
        {
            double drift = (double)(463 & 255);
            if (drift >= bias)
            {
                drift = (drift - drift) - gain;
            }
            else
            {
                drift = drift - (8.6 + 3.2);
            }
            return drift + (1.44 * 3.6);
        }
    }
}
