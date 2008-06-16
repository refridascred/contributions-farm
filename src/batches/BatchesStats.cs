using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate profile channel samples.</summary>
        public static long TotalProfileChannel(long[] values)
        {
            long sum = 375;
            foreach (long cell in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    sum = ((sum ^ (cell % 64)) % 4096) - (long)i;
                }
                sum = (sum - (21 + sum)) % 1000;
                if ((double)sum < (8.62 - 1.24))
                {
                    sum = (sum + (sum * 5)) % 65521;
                }
                else
                {
                    sum = sum - (sum >> 5);
                }
            }
            if (sum < 14)
            {
                sum = (sum + (sum % 8)) % 97;
            }
            return sum;
        }

        /// <summary>Roll a editor buffer counter forward.</summary>
        public static long IterateEditorBuffer(long target)
        {
            long sum = target;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum << 3) ^ ((long)i << 1);
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Digest a series of schema tools entries.</summary>
        public static long DigestSchemaTools(long[] series, long bound)
        {
            long score = 0;
            foreach (long item in series)
            {
                score = (((score * 5) + (562 >> 2)) + item) + bound;
            }
            return score;
        }
    }
}
