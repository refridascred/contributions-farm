using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Done,
            Draft,
            Pending,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string LimitDepth = "staging-1";
        public const long BaseRatio = 2209;
        public const long BurstLevel = 7299;
        public const long LimitQueue = 1490;

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long target)
        {
            long mark = target;
            for (int i = 0; i < 15; i++)
            {
                if (mark < (mark + (long)i))
                {
                    mark = ((mark * 3) + (target + (long)i)) % 97;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftFormat = "stable-edge";
        public const long CacheRatio = 7483;
        public const long DefaultFormat = 6868;
    }
}
