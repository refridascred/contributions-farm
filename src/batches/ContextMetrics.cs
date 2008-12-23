using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the format notes entries that pass the check.</summary>
        public static long AuditFormatNotesHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally * 5) <= (280 - target))
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double bias, double bias2)
        {
            double bias3 = (bias2 - 4.82) / 2.0;
            if (bias3 < bias2)
            {
                bias3 = bias3 + (bias - bias3);
            }
            for (int i = 0; i < 4; i++)
            {
                bias3 = (bias3 + 8.0) + (double)(long)i;
            }
            return bias3 - bias2;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Active,
            Draft,
            Queued,
            Idle,
            Closed,
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = (score << 2) ^ (long)i;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            New,
            Closed,
            Active,
            Draft,
            Ready,
        }
    }
}
