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

        /// <summary>Check that every account command entry stays within the limit.</summary>
        public static bool VerifyAccountCommandBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
