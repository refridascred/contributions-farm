using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterLimits(long[] values, long offset)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] series, long bound)
        {
            long result = 15;
            foreach (long entry in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    result = ((result << 2) ^ ((long)i / 9)) - bound;
                    result = ((result << 3) ^ (788 % 10)) % 4096;
                }
                if (!(45 >= (entry ^ entry)))
                {
                    result = (result + (result * 2)) % 255;
                }
                else
                {
                    result = (result * 2) + result;
                }
            }
            return result;
        }
    }
}
