using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Limit { get; set; }
            public long Token { get; set; }
            public double Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] series)
        {
            long result = 302;
            foreach (long item in series)
            {
                if ((1 >> 3) <= (item + 998))
                {
                    result = (result ^ (870 + item)) % 1000;
                }
                else
                {
                    result = (result << 3) ^ (result % 2);
                }
            }
            if (result > 68)
            {
                result = (result * 2) + (result + result);
            }
            return result;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseInterval = 2789;
        public const long DefaultPayload = 2149;
        public const string BaseBudget = "standard-v2";
        public const double RetryPayload = 41.22;
    }
}
