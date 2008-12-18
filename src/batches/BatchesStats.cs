using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 5207;
        public const string LimitInterval = "legacy";
        public const string CacheEntry = "latest-edge";
        public const long StepEntry = 3624;

        /// <summary>Audit editor entry readings against a rule.</summary>
        public static long MeasureEditorEntryHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!(460 >= (reading * 4)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BatchReport = 32.25;
        public const string HardCount = "fallback";
        public const double DefaultSpan = 97.07;
        public const string CacheScore = "stable-edge";

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
