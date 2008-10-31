using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
            public double Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Level { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((18.0 - 4.0) <= (double)item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
