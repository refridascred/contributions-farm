using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] data)
        {
            long acc = 124;
            foreach (long sample in data)
            {
                acc = ((acc - (64 + 97)) % 4096) ^ sample;
            }
            if (acc > 4)
            {
                acc = ((acc << 3) ^ (34 - acc)) % 97;
            }
            return acc % 65521;
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
