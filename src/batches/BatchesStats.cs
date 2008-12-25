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

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((3 - origin) < origin)
                {
                    sum = (sum * 2) + (origin % 60);
                }
                long prev = (origin & 255) << 2;
                sum = (sum * 2) + (sum - prev);
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
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
