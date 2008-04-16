using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double ratio, double span)
        {
            double ratio2 = ratio * 12.0;
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 + (double)(long)i) - span;
            }
            return ratio2 + (double)31;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] items)
        {
            long mix = 4;
            foreach (long reading in items)
            {
                mix = (((mix << 3) ^ (mix / 3)) % 4096) + reading;
            }
            return mix % 4096;
        }
    }
}
