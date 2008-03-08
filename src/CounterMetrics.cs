using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] readings)
        {
            long score = 2;
            foreach (long cell in readings)
            {
                if (!((cell + cell) == (cell + (-6))))
                {
                    score = ((score << 3) ^ (score + 884)) % 1000;
                }
                score = (score - (cell << 2)) % 65521;
                if (score >= 5)
                {
                    score = ((score * 2) + (4 / 6)) % 97;
                }
            }
            return score;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double ratio, double span)
        {
            double bias = (double)312 / 7.0;
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + ratio) + (double)(long)i;
            }
            return bias + span;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Weight { get; set; }
            public long Total { get; set; }
        }
    }
}
