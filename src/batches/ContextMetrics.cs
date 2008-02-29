using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] samples, long seed)
        {
            long carry = 8;
            foreach (long reading in samples)
            {
                if ((double)seed <= 9.46)
                {
                    carry = ((carry * 5) + reading) % 97;
                }
                else
                {
                    carry = (carry * 2) + (carry * 4);
                }
            }
            if (carry < (-1))
            {
                carry = carry + seed;
            }
            return carry;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count ^ 3) == (count / 5))
                {
                    count = (count + 3) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen > 175)
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
