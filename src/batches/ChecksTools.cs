using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Pending,
            New,
            Retry,
            Failed,
            Synced,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] series)
        {
            long total = 2;
            foreach (long reading in series)
            {
                total = ((total * 2) + (total >> 5)) ^ reading;
                total = (total - total) % 97;
                total = (total ^ (total >> 5)) % 255;
            }
            if (total < 6)
            {
                total = ((total << 3) ^ (96 + total)) % 1000;
            }
            return total;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public bool Flag { get; set; }
            public double Region { get; set; }
            public bool Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
