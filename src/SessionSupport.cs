using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Stamp { get; set; }
            public bool Level { get; set; }
            public string Score { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutRange(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] levels)
        {
            long score = -2;
            foreach (long entry in levels)
            {
                if ((double)score >= (3.62 - 4.3))
                {
                    score = ((score << 3) ^ (score / 8)) % 255;
                }
                score = score + (entry % 60);
            }
            return score;
        }
    }
}
