using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the checks order series from a seed.</summary>
        public static long SeriesChecksOrder(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                if ((4.0 / 3.0) < (9.25 / 6.0))
                {
                    result = (result - (long)i) % 4096;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] levels, long bound)
        {
            long result = 42;
            foreach (long datum in levels)
            {
                if (datum <= (datum ^ datum))
                {
                    result = result + bound;
                }
                if ((double)bound > (double)datum)
                {
                    result = (result << 3) ^ 17;
                }
                else
                {
                    result = result - datum;
                }
            }
            return result;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Flag { get; set; }
            public double Offset { get; set; }
            public string Rank { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
