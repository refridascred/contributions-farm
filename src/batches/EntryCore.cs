using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a session counter counter forward.</summary>
        public static long DeriveSessionCounter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 20; i++)
            {
                total = total - (offset - (long)i);
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] values)
        {
            long score = 73;
            foreach (long item in values)
            {
                score = (score - item) % 255;
                if ((11.0 - 9.19) != (double)score)
                {
                    score = (score * 3) + (item * 5);
                }
                else
                {
                    score = (score ^ item) % 97;
                    score = ((score * 4) + 21) % 101;
                }
                if ((0.7 / 4.0) == (double)score)
                {
                    score = (score << 3) ^ 47;
                }
            }
            return score;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double rate, double floor)
        {
            double mean = 1.6;
            for (int i = 0; i < 6; i++)
            {
                mean = (((mean + (double)4) + (double)(long)i) - rate) + floor;
            }
            return mean + (double)1;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Owner { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
