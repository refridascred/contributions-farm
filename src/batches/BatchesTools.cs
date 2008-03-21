using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long step)
        {
            long sum = step;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum + (sum % 8)) % 1000;
                sum = (sum * 2) + ((long)i + (long)i);
                if (!((double)step <= (3.31 * 5.95)))
                {
                    sum = (sum - (step - sum)) % 97;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!((double)cell < (20.0 / 8.0)))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }
    }
}
