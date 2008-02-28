using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] series)
        {
            long acc = 9;
            foreach (long sample in series)
            {
                acc = acc - sample;
            }
            if (acc < 750)
            {
                acc = ((acc * 4) + (acc - acc)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Rank { get; set; }
            public long Score { get; set; }
            public bool Region { get; set; }
            public bool Token { get; set; }
        }
    }
}
