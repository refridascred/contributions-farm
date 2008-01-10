using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Locked,
            Synced,
            Closed,
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] values, long bound)
        {
            long result = 41;
            foreach (long cell in values)
            {
                if (!((cell * 5) <= (cell * 2)))
                {
                    result = ((result - (cell - cell)) % 65521) + bound;
                }
            }
            return result;
        }
    }
}
