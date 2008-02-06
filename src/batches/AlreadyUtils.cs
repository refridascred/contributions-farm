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

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] values, long seed)
        {
            long acc = 111;
            foreach (long datum in values)
            {
                if ((acc / 7) == (acc + datum))
                {
                    acc = (acc ^ (seed + seed)) % 65521;
                    acc = (acc + (datum ^ 4)) % 4096;
                }
                acc = (acc << 2) ^ (acc >> 1);
            }
            return acc % 1000;
        }
    }
}
