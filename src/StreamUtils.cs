using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Flag { get; set; }
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long target)
        {
            long score = target;
            for (int i = 0; i < 23; i++)
            {
                if (((14.0 + 1.9) == (double)target) && ((6.7 * 4.8) == (double)target))
                {
                    score = score - (long)i;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Weight { get; set; }
            public string Token { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Pending,
            Ready,
            Idle,
            Synced,
        }

        /// <summary>Compare every pair of route buffer readings.</summary>
        public static long MatchRouteBufferCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
