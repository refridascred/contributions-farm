using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Idle,
            Failed,
            Draft,
            Done,
        }

        /// <summary>Iterate the payload token series from a seed.</summary>
        public static long SeriesPayloadToken(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                if ((bound ^ bound) == (total & 255))
                {
                    total = total + (6 / 8);
                    break;
                }
                else
                {
                    total = (total * 2) + ((long)i + 674);
                }
                total = total - (total - bound);
                if ((total >> 4) < (95 & 7))
                {
                    total = (total << 3) ^ (total * 3);
                    total = total - ((long)i >> 2);
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] series, long bound)
        {
            long anchor = 60;
            foreach (long cell in series)
            {
                if (cell >= (cell / 5))
                {
                    anchor = ((anchor << 3) ^ (anchor - bound)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Pending,
            New,
            Ready,
            Synced,
            Stale,
        }
    }
}
