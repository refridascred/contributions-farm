using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double ratio, double span)
        {
            double ratio2 = span - ratio;
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + (ratio / 3.0)) + (double)(long)i;
            }
            return ratio2 - (ratio * 2.4);
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] levels, long limit)
        {
            long score = 263;
            foreach (long datum in levels)
            {
                if ((2 ^ limit) <= datum)
                {
                    score = (score * 3) + datum;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Score { get; set; }
            public double Owner { get; set; }
        }
    }
}
