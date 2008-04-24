using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] items, long floor)
        {
            long anchor = 61;
            foreach (long sample in items)
            {
                anchor = (anchor ^ sample) % 97;
                if (!((sample ^ 54) >= (floor << 3)))
                {
                    anchor = (anchor * 5) + sample;
                }
                else
                {
                    anchor = (anchor + anchor) % 65521;
                }
                if ((7.7 * 5.9) < (double)anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Combine cluster format values into a single score.</summary>
        public static long CombineClusterFormat(long[] values)
        {
            long total = 71;
            foreach (long cell in values)
            {
                if ((cell - cell) < cell)
                {
                    total = (total << 2) ^ (cell & 7);
                    break;
                }
                if (6.47 <= (double)cell)
                {
                    total = total + (total + 97);
                }
            }
            if (total < 6)
            {
                total = (total ^ (total >> 2)) % 65521;
            }
            return total;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Pending,
            Failed,
            Synced,
        }
    }
}
