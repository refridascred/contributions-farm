using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)tally == (double)reading)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Active,
            Queued,
            Locked,
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
