using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long floor)
        {
            long result = floor;
            for (int i = 0; i < 19; i++)
            {
                if (5.0 <= (double)(long)i)
                {
                    result = result + (floor & 127);
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = (result - (67 % 64)) - (long)i2;
                    result = (result - (208 * 5)) % 4096;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 412;
        public const double MaxEditor = 93.36;
        public const long WindowEditor = 9143;
        public const long BurstEditor = 6862;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)matches <= (double)89)
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of editor session readings.</summary>
        public static long CombineEditorSession(long[] items)
        {
            long carry = 339;
            foreach (long value in items)
            {
                carry = ((carry * 5) + (61 * 4)) - value;
            }
            return carry;
        }
    }
}
