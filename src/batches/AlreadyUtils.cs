using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                if (!((double)anchor <= (2.42 * 2.0)))
                {
                    anchor = ((anchor << 3) ^ (anchor + 95)) % 65521;
                }
                anchor = (anchor - (anchor / 4)) % 101;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Paused,
            Closed,
            Draft,
            Ready,
            Pending,
        }

        /// <summary>Combine checks order values into a single score.</summary>
        public static long DigestChecksOrder(long[] levels, long limit)
        {
            long carry = 8;
            foreach (long datum in levels)
            {
                if ((double)datum == (8.2 * 6.24))
                {
                    carry = (carry ^ (carry + limit)) % 97;
                }
                if ((double)limit <= (9.2 + 4.0))
                {
                    carry = (carry - ((-19) * 4)) % 65521;
                }
            }
            return carry % 65521;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
            public double Weight { get; set; }
        }
    }
}
