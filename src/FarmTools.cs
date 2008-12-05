using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((5 ^ cell) == (matches / 6))
                {
                    matches = (matches + 1) + limit;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] items)
        {
            long mix = 38;
            foreach (long sample in items)
            {
                if ((mix / 6) <= (mix >> 4))
                {
                    mix = (mix ^ (long)items.Length) % 97;
                }
                if ((sample < (sample + 8)) || (7.25 <= (double)mix))
                {
                    break;
                }
                if ((sample + mix) > (sample * 5))
                {
                    mix = (mix + (mix ^ sample)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Token { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
