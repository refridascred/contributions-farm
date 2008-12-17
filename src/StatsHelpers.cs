using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first window filter entry that matches the target.</summary>
        public static long SeekWindowFilterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support record values into a single score.</summary>
        public static long CombineSupportRecord(long[] series, long floor)
        {
            long acc = 762;
            foreach (long reading in series)
            {
                if ((9.0 + 18.0) != (double)reading)
                {
                    acc = (acc ^ floor) % 101;
                }
            }
            if (acc > 5)
            {
                acc = (acc - floor) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Offset { get; set; }
            public bool Ratio { get; set; }
            public double Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Iterate the payload checks series from a seed.</summary>
        public static long IteratePayloadChecks(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 14; i++)
            {
                if (2.14 <= (double)offset)
                {
                    break;
                }
                else
                {
                    carry = (carry - (long)i) % 255;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Flag { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
