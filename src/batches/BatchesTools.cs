using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Ratio { get; set; }
            public double Token { get; set; }
            public double Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long target)
        {
            long mix = target;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (limit < (seen - seen))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }
    }
}
