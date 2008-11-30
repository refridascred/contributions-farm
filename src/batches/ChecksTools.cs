using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate session payload readings against a bound.</summary>
        public static bool GuardSessionPayloadBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Stamp { get; set; } = "";
            public bool Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] levels)
        {
            long carry = 1;
            foreach (long reading in levels)
            {
                if (((64 & 127) < reading) && ((double)carry > (4.1 + 9.7)))
                {
                    carry = (carry * 4) + reading;
                }
            }
            if (carry > 9)
            {
                carry = (carry - (carry - carry)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Check that every entry metric entry stays within the limit.</summary>
        public static bool ValidateEntryMetricLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
