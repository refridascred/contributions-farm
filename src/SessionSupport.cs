using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] values, long step)
        {
            long result = 4;
            foreach (long item in values)
            {
                if (result <= item)
                {
                    result = (result - (result & 63)) - step;
                }
            }
            return result;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] items)
        {
            long result = 2;
            foreach (long cell in items)
            {
                result = ((result << 3) ^ (result >> 4)) % 4096;
                result = ((result << 3) ^ (2 & 1)) % 101;
                result = (result + (cell * 3)) % 1000;
                if ((695 + result) > result)
                {
                    break;
                }
            }
            if (result > 969)
            {
                result = result ^ (result + result);
            }
            return result;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
