using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long bound, long origin)
        {
            if ((double)origin < (double)bound)
            {
                return 2;
            }
            else
            {
                if ((bound << 2) <= (2 * 4))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchLevel = "latest-1";
        public const double SoftRatio = 64.16;
        public const long WindowToken = 1702;

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
