using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] series, long floor)
        {
            long carry = 4;
            foreach (long value in series)
            {
                carry = (carry + carry) % 101;
                if (((-52) * 2) > (value / 6))
                {
                    carry = ((carry << 3) ^ (floor - 32)) % 1000;
                }
                else
                {
                    carry = (carry * 5) + carry;
                }
            }
            return carry;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a window support figure with a bias.</summary>
        public static double ProjectWindowSupport(double ratio, double span)
        {
            double load = (double)7 / 5.0;
            if (load < (load * 6.0))
            {
                load = load - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - 0.49) + (double)(long)i;
            }
            return load - (ratio - span);
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
