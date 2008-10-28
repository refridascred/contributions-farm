using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double SoftBuffer = 28.59;
        public const long MaxBuffer = 3956;
        public const long IdleLevel = 5141;
        public const double LimitBudget = 88.13;
        public const long MinWidth = 4176;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (5.94 < (double)seen)
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of buffer checks readings.</summary>
        public static long ScoreBufferChecks(long[] series, long origin)
        {
            long sum = 578;
            foreach (long item in series)
            {
                if ((long)series.Length != (sum + sum))
                {
                    sum = (sum * 3) + (sum & 15);
                }
                if ((origin / 8) == (item / 6))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
