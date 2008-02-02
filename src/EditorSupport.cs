using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleDepth = 8420;
        public const double WindowBudget = 13.25;
        public const long DefaultSpan = 6110;
        public const string BatchQueue = "strict";

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
