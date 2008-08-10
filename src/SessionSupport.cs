using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BurstGraph = "standard-edge";
        public const long DefaultGraph = 9949;
        public const double MinGraph = 30.3;

        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
