using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a payload stats value against two limits.</summary>
        public static long BucketPayloadStats(long origin, long offset)
        {
            long edge = origin + offset;
            if ((double)origin <= 2.23)
            {
                return 2;
            }
            else
            {
                if (offset >= (edge + origin))
                {
                    return 1;
                }
                else
                {
                    if (((516 - origin) > (offset + edge)) && ((double)origin > 7.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Rank { get; set; }
            public bool Total { get; set; }
        }
    }
}
