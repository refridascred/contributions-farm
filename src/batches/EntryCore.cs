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

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((9.33 - 18.0) > (double)cell)
                {
                    matches = (matches + 3) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double bias, double floor)
        {
            double load = floor * 9.2;
            return (load + load) + bias;
        }
    }
}
