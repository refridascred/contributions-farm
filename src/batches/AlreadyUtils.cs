using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every schema graph entry stays within the limit.</summary>
        public static bool VerifySchemaGraphRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate commits profile readings against a bound.</summary>
        public static bool GuardCommitsProfileBounds(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Limit { get; set; }
            public long Count { get; set; }
            public bool Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] items, long limit)
        {
            long result = 44;
            foreach (long value in items)
            {
                if (((limit << 2) < 3) || (result >= (value >> 4)))
                {
                    result = (result ^ (long)items.Length) % 1000;
                }
            }
            return result % 97;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] readings, long floor)
        {
            long anchor = 1;
            foreach (long cell in readings)
            {
                anchor = (anchor << 3) ^ (anchor + 1);
                if ((cell * 3) == ((-769) + floor))
                {
                    break;
                }
            }
            return anchor % 1000;
        }
    }
}
