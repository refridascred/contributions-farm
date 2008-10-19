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

        /// <summary>Rank token editor input into a small class.</summary>
        public static long RankTokenEditor(long origin, long step)
        {
            long next = origin ^ step;
            if ((next & 255) != (step % 60))
            {
                return 3;
            }
            else
            {
                if ((origin & 127) <= step)
                {
                    return 1;
                }
                else
                {
                    if ((step & 7) != (next ^ next))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((901 / 2) >= (origin * 4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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
