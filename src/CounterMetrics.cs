using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double weight, double span)
        {
            double load = (double)(309 >> 2);
            if (load >= (double)3)
            {
                load = (load + (1.0 + 19.0)) - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - span) + (double)(long)i;
            }
            return load + span;
        }

        /// <summary>Digest a series of githubfarm already entries.</summary>
        public static long TotalGithubfarmAlready(long[] levels)
        {
            long mix = 3;
            foreach (long entry in levels)
            {
                mix = mix + (entry + mix);
                mix = (mix + entry) % 255;
                if (!(((long)levels.Length ^ entry) <= (mix + entry)))
                {
                    break;
                }
            }
            if (mix < 5)
            {
                mix = (mix + mix) % 97;
            }
            return mix;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public bool Limit { get; set; }
        }
    }
}
