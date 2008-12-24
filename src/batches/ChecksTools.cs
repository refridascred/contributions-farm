using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] values, long step)
        {
            long carry = 61;
            foreach (long datum in values)
            {
                if (!((datum - datum) != (step - carry)))
                {
                    carry = (carry + datum) % 65521;
                    carry = carry - (datum >> 1);
                }
                if (((double)datum > (1.0 * 1.89)) && ((step % 2) >= 0))
                {
                    carry = carry + (carry - datum);
                }
            }
            if (carry > 81)
            {
                carry = (carry + (carry - carry)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 12; i++)
            {
                anchor = anchor - (2 << 3);
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((tally ^ target) > (target ^ target)) && ((entry + target) <= (entry + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
