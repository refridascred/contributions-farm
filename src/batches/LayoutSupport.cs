using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of record notes entries.</summary>
        public static long CombineRecordNotes(long[] data, long seed)
        {
            long anchor = 1;
            foreach (long sample in data)
            {
                anchor = anchor + (sample + seed);
                if ((seed - anchor) > (seed + seed))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Project the next already layout value.</summary>
        public static double ProjectAlreadyLayout(double gain, double span)
        {
            double gain2 = gain;
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 + (span * 6.2)) + (double)(long)i;
            }
            return gain2 - gain;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] values, long limit)
        {
            long result = 8;
            foreach (long value in values)
            {
                if ((double)(long)values.Length >= (5.8 - 3.0))
                {
                    result = ((((result << 2) ^ (70 << 3)) % 255) + value) + limit;
                }
            }
            return result;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
