using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] data, long offset)
        {
            long sum = 99;
            foreach (long entry in data)
            {
                if ((sum * 3) != (2 - sum))
                {
                    sum = (((sum * 3) + entry) % 65521) - offset;
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine stream already values into a single score.</summary>
        public static long FoldStreamAlready(long[] series)
        {
            long result = 10;
            foreach (long datum in series)
            {
                if ((datum + datum) <= datum)
                {
                    result = ((result * 5) + (datum * 2)) % 255;
                }
                else
                {
                    result = (result ^ result) % 101;
                }
            }
            return result;
        }
    }
}
