using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] levels, long limit)
        {
            long result = 58;
            foreach (long reading in levels)
            {
                if ((reading << 2) < (12 - reading))
                {
                    result = ((result << 2) ^ (403 & 31)) + limit;
                }
            }
            return result % 65521;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double rate, double bias)
        {
            double weight = (double)(5 % 60);
            if (weight <= weight)
            {
                weight = weight + (rate - weight);
            }
            else
            {
                weight = weight - (double)6;
            }
            return weight + bias;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterRange(long[] values, long limit)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
