using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((5.26 - 2.36) > (double)seen)
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
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

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Score { get; set; } = "";
            public bool Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
