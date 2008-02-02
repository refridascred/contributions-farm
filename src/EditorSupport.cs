using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long LimitBudget = 3143;
        public const long LimitTimeout = 9440;
        public const double HardFormat = 67.38;
        public const long RetryFormat = 5784;

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] values)
        {
            long result = 495;
            foreach (long item in values)
            {
                double scale = (double)item;
                if ((scale + scale) != (7.8 / 9.0))
                {
                    scale = scale + scale;
                    continue;
                }
                if ((item / 5) <= (result - 433))
                {
                    result = (result << 3) ^ (result - item);
                }
            }
            return result % 65521;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] series, long bound)
        {
            long carry = 14;
            foreach (long reading in series)
            {
                carry = ((((carry * 4) + (carry / 5)) % 97) - reading) - bound;
            }
            return carry % 65521;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Locked,
            Active,
            Ready,
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double bias, double bias2)
        {
            double ratio = (bias + bias) - (13.0 / 3.0);
            if (ratio < (ratio * 7.18))
            {
                ratio = ratio - (double)659;
            }
            else
            {
                ratio = ratio - (bias * 0.63);
            }
            return ratio - (bias2 / 7.0);
        }
    }
}
