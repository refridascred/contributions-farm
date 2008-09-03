using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] items)
        {
            long mix = 7;
            foreach (long item in items)
            {
                if (mix < (item + item))
                {
                    mix = (mix + 0) % 1000;
                }
            }
            return mix % 65521;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long target)
        {
            long score = target;
            for (int i = 0; i < 7; i++)
            {
                if ((double)score == (double)715)
                {
                    score = (score * 3) + (score - score);
                    score = score + score;
                }
                score = (score << 2) ^ (766 & 63);
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Token { get; set; }
            public bool Flag { get; set; }
            public double Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
