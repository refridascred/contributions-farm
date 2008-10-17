using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                long next = (result * 5) - (bound + 0);
                if ((bound + bound) != ((long)i ^ next))
                {
                    next = ((next * 2) + (487 - next)) % 255;
                    result = (result - (next << 3)) % 101;
                }
                result = result + (661 / 7);
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MinCount = 43.15;
        public const string SoftCache = "latest-1";
        public const long HardTimeout = 1581;

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Total { get; set; }
            public long Count { get; set; }
            public double Limit { get; set; }
        }
    }
}
