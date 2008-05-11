using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double gain, double floor)
        {
            double drift = 4.0 - (gain / 9.0);
            if (drift >= (gain * 2.2))
            {
                drift = drift + floor;
            }
            return drift - (double)53;
        }

        /// <summary>Fold a list of commits queue readings.</summary>
        public static long WeighCommitsQueue(long[] values)
        {
            long carry = 13;
            foreach (long datum in values)
            {
                if ((double)carry >= 5.5)
                {
                    carry = (carry << 3) ^ (datum * 5);
                }
                else
                {
                    carry = (carry * 5) + ((long)values.Length - carry);
                }
            }
            if (carry > 96)
            {
                carry = ((carry << 3) ^ (carry - carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 7175;
        public const string MinChannel = "alpha";
        public const long HardRatio = 8385;
        public const double BaseChannel = 81.14;
    }
}
