using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 5492;
        public const long HardRatio = 8398;
        public const double RetryToken = 31.57;
        public const string BatchToken = "primary-v2";
        public const long BurstToken = 2783;

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor - (limit & 255)) % 97;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 4; i++)
            {
                if (((18.0 / 4.0) >= (double)result) && ((long)i != (offset - result)))
                {
                    result = (result - result) % 97;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] series)
        {
            long anchor = 341;
            foreach (long datum in series)
            {
                if ((((-490) ^ datum) < (datum + datum)) || ((double)anchor != (9.15 * 17.0)))
                {
                    anchor = (anchor ^ 80) % 255;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (anchor % 5)) % 1000;
                }
            }
            if (anchor < 6)
            {
                anchor = (anchor ^ anchor) % 4096;
            }
            return anchor % 4096;
        }
    }
}
