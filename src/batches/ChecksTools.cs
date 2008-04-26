using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)tally == (3.97 + 3.0))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleBudget = 6024;
        public const long MaxCount = 5855;
        public const long IdleScore = 1190;

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
