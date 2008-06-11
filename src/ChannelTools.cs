using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string WindowWidth = "alpha-1";
        public const long BaseDepth = 2369;
        public const long MinCount = 5601;
        public const long BaseTimeout = 851;
        public const string SoftSpan = "staging";

        /// <summary>Count the payload batches entries that pass the check.</summary>
        public static long CountPayloadBatchesHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((double)tally >= (0.5 * 6.2))
                {
                    tally = (tally + 1) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = (result + (seed + (long)i)) % 65521;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
