using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] values, long floor)
        {
            long total = 535;
            foreach (long datum in values)
            {
                if ((floor & 3) <= datum)
                {
                    total = (total + (total / 6)) % 1000;
                    total = ((total * 3) + total) % 1000;
                }
                if (((floor & 127) == (total + datum)) || ((total * 4) == (1 & 7)))
                {
                    total = ((total * 4) + (16 + floor)) % 255;
                }
            }
            if (total < 5)
            {
                total = (total << 3) ^ (total - 729);
            }
            return total % 1000;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Total { get; set; }
            public double Region { get; set; }
        }
    }
}
