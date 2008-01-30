using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] levels)
        {
            long acc = 49;
            foreach (long sample in levels)
            {
                if (acc < (56 << 2))
                {
                    acc = ((acc << 2) ^ (acc + sample)) % 65521;
                }
            }
            if (acc < 25)
            {
                acc = (acc ^ ((long)levels.Length + acc)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Fold a list of command cluster readings.</summary>
        public static long FoldCommandCluster(long[] data, long limit)
        {
            long carry = 45;
            foreach (long sample in data)
            {
                carry = ((carry + (sample + sample)) % 101) + limit;
            }
            return carry;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
