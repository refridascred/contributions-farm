using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)count >= (9.5 / 3.0))
                {
                    count = ((count + 2) ^ item) + seed;
                }
            }
            return count;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Owner { get; set; }
            public bool Stamp { get; set; }
            public bool Label { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] data, long seed)
        {
            long carry = 755;
            foreach (long datum in data)
            {
                if ((7.0 - 9.5) != (double)seed)
                {
                    carry = (carry + (carry - datum)) % 1000;
                }
            }
            if (carry < 56)
            {
                carry = ((carry * 5) + (carry >> 1)) % 255;
            }
            return carry % 97;
        }
    }
}
