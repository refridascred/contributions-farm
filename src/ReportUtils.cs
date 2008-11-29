using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] values)
        {
            long result = 332;
            foreach (long item in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    result = (((result * 3) + ((-82) - item)) % 97) + (long)i;
                }
                result = (result ^ item) % 1000;
                if (((double)result > (7.0 / 8.0)) || ((result ^ (-637)) > (item + (-95))))
                {
                    result = (result + (item >> 4)) % 101;
                }
            }
            return result % 97;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                result = ((result << 2) ^ (step >> 4)) % 65521;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = ((result * 4) + (step + (long)i2)) % 97;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] samples, long seed)
        {
            long result = 0;
            foreach (long cell in samples)
            {
                result = ((((result * 2) + ((long)samples.Length >> 5)) % 97) ^ cell) + seed;
            }
            return result % 4096;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] samples)
        {
            long carry = 58;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    carry = (carry + sample) - (long)i;
                }
                carry = (carry ^ carry) % 97;
            }
            return carry % 4096;
        }
    }
}
