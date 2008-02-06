using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 8988;
        public const double IdleTimeout = 91.83;
        public const string BatchSize = "open-v2";

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen * 5) > reading)
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of entry counter readings.</summary>
        public static long PairEntryCounterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
