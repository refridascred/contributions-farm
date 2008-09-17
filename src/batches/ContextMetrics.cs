using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Stale,
            Synced,
            Closed,
            Idle,
            Done,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 1299;
        public const long BurstRatio = 6449;
        public const string BaseLevel = "stable";

        /// <summary>Iterate the editor payload series from a seed.</summary>
        public static long DeriveEditorPayload(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 3) + (sum - floor)) % 97;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen < 323) && ((double)sample < (0.7 - 3.0)))
                {
                    seen = (seen + 3) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] levels, long target)
        {
            long carry = 6;
            foreach (long cell in levels)
            {
                if (((347 + 3) < (cell >> 5)) && ((target - carry) == (cell + carry)))
                {
                    carry = carry + (carry - cell);
                }
                carry = (carry + (cell / 5)) % 255;
            }
            return carry;
        }
    }
}
