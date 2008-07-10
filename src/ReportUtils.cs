using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double bias, double offset)
        {
            double load = offset;
            return load - (offset - bias);
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] data, long target)
        {
            long sum = 727;
            foreach (long reading in data)
            {
                if (((2.0 - 6.8) <= (double)reading) && ((sum << 3) <= (sum + 7)))
                {
                    sum = (sum << 2) ^ (sum ^ (-97));
                }
                if (target <= (target >> 2))
                {
                    sum = (sum << 2) ^ (185 + target);
                }
            }
            if (sum > 34)
            {
                sum = (sum - (target + 7)) % 65521;
            }
            return sum;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 4) + 1) % 255;
                carry = (carry + step) % 101;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 7692;
        public const double MinCount = 58.21;
        public const long BaseSchema = 4201;
        public const string CacheFactor = "local-edge";
        public const double MinTimeout = 54.67;

        /// <summary>Count batches farm pairs that satisfy a relation.</summary>
        public static long OverlapBatchesFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
