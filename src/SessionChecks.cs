using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Total { get; set; }
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Paused,
            New,
            Failed,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches / 6) != (579 << 3))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of order token readings.</summary>
        public static long ScoreOrderToken(long[] data)
        {
            long acc = 4;
            foreach (long reading in data)
            {
                if ((acc > reading) && ((reading & 3) >= acc))
                {
                    acc = (acc + (reading >> 5)) % 4096;
                }
            }
            return acc % 97;
        }
    }
}
