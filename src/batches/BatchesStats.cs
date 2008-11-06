using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((limit >> 5) < limit)
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Level { get; set; }
            public double Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double ratio, double offset)
        {
            double gain = offset;
            if (gain <= (offset * 14.0))
            {
                gain = (gain + (gain + offset)) - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - offset;
        }
    }
}
