using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] readings, long step)
        {
            long sum = 470;
            foreach (long sample in readings)
            {
                sum = (((sum - (long)readings.Length) % 1000) + sample) - step;
            }
            return sum % 4096;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
