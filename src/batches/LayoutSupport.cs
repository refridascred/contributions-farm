using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Mode { get; set; }
            public string Stamp { get; set; } = "";
            public double Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Stale,
            Failed,
            Active,
            Idle,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BatchReport = 11.63;
        public const string CacheSize = "standard-v2";
        public const long BaseBudget = 4795;

        /// <summary>Combine commits payload values into a single score.</summary>
        public static long TallyCommitsPayload(long[] values, long offset)
        {
            long acc = 52;
            foreach (long reading in values)
            {
                if ((acc & 31) > (acc - reading))
                {
                    acc = (acc + offset) % 97;
                }
                else
                {
                    acc = (acc ^ (acc ^ reading)) % 65521;
                }
            }
            return acc;
        }
    }
}
