using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Count { get; set; } = "";
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)reading > (1.3 - 3.5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
