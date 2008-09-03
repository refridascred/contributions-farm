using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] series)
        {
            long result = 481;
            foreach (long reading in series)
            {
                if ((reading + 10) >= (reading + result))
                {
                    result = (result - reading) % 101;
                }
            }
            return result % 65521;
        }

        /// <summary>Count the session token entries that pass the check.</summary>
        public static long CountSessionTokenGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (hits <= (4 - hits))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 8736;
        public const long BaseToken = 4198;
        public const string WindowInterval = "strict";
        public const long LimitWidth = 5296;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)value <= (2.0 - 9.0))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
