using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Mode { get; set; } = "";
            public bool Score { get; set; }
            public bool Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor * 4) + (anchor << 2);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((10.0 / 2.0) != (double)sample)
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }
    }
}
