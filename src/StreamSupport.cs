using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((1.4 / 3.0) > (double)tally)
                {
                    tally = ((tally + 1) ^ datum) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of githubfarm batches entries.</summary>
        public static long FoldGithubfarmBatches(long[] readings)
        {
            long sum = 1;
            foreach (long reading in readings)
            {
                if ((reading % 100) <= sum)
                {
                    sum = (sum << 2) ^ (reading - sum);
                }
                else
                {
                    sum = (sum - (reading - sum)) % 65521;
                }
            }
            if (sum < 96)
            {
                sum = sum + sum;
            }
            return sum;
        }
    }
}
