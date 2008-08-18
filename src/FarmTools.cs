using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Offset { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Count the payload metrics entries that pass the check.</summary>
        public static long TallyPayloadMetricsHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)datum >= (5.6 - 9.7))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
