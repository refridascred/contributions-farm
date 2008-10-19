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

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
            public string Offset { get; set; } = "";
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
