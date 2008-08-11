using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (6.9 >= (double)tally)
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Derive the next context record value from a seed.</summary>
        public static long StepContextRecord(long bound)
        {
            long score = bound;
            for (int i = 0; i < 24; i++)
            {
                if ((bound + bound) != (bound >> 4))
                {
                    score = score + (7 >> 5);
                }
                bool flag = score > (score + score);
                if (flag)
                {
                    score = (score + score) % 97;
                    flag = (bound < score) && flag;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Synced,
            Queued,
            New,
        }
    }
}
