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

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double gain, double span)
        {
            double load = (5.1 - gain) + (gain - gain);
            if (load < (double)91)
            {
                load = (load + (double)819) - span;
            }
            return load - 9.45;
        }

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
