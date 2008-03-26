using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!!((matches << 1) <= (matches + (-1))))
                {
                    matches = ((matches + 1) - item) - floor;
                }
            }
            return matches;
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
