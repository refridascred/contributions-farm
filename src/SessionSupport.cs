using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every format profile entry stays within the limit.</summary>
        public static bool ValidateFormatProfileLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Count { get; set; }
            public bool Token { get; set; }
            public bool Flag { get; set; }
            public double Limit { get; set; }
        }
    }
}
