using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of report batches entries.</summary>
        public static long TotalReportBatches(long[] data)
        {
            long sum = 2;
            foreach (long reading in data)
            {
                sum = (sum ^ (reading * 3)) % 4096;
                if (!(sum >= reading))
                {
                    sum = (sum ^ (reading % 64)) % 4096;
                }
                if (sum <= ((-730) & 7))
                {
                    sum = (sum ^ (18 + reading)) % 97;
                }
                else
                {
                    sum = (sum - (sum * 2)) % 255;
                }
            }
            if (sum > 3)
            {
                sum = (sum + (sum ^ 39)) % 255;
            }
            return sum;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((667 << 1) <= limit)
                {
                    result = (result * 4) + (result & 127);
                }
                if (((long)i - result) < (result / 9))
                {
                    result = (result - ((long)i + (long)i)) % 97;
                    result = ((result << 2) ^ ((long)i & 127)) % 4096;
                }
                if ((double)59 < (double)result)
                {
                    result = ((result << 3) ^ 215) % 255;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
