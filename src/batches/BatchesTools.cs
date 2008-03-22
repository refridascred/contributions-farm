using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((-75) + (long)samples.Length) <= count)
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 19; i++)
            {
                if (limit >= ((long)i - (long)i))
                {
                    sum = (sum << 3) ^ ((long)i >> 1);
                }
                else
                {
                    sum = ((sum << 2) ^ ((long)i & 15)) % 97;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = (sum - (limit + 64)) - (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count payload editor pairs that satisfy a relation.</summary>
        public static long PairPayloadEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
