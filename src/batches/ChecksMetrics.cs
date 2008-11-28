using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (9.7 > (double)floor)
                {
                    seen = (seen + 1) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Retry,
            Closed,
            Ready,
            Paused,
            Idle,
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Weight { get; set; }
            public double Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long seed, long bound)
        {
            long gap = seed ^ bound;
            if (bound >= (30 - 8))
            {
                return 0;
            }
            else
            {
                if ((double)bound >= (0.8 / 2.0))
                {
                    return 4;
                }
                else
                {
                    if (gap > (gap + 4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public long Ratio { get; set; }
        }
    }
}
