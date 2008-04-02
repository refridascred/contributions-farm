using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public double Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Classify a format token pair into a bucket.</summary>
        public static long ClassifyFormatToken(long target, long step)
        {
            long bound = target + step;
            if ((step & 1) > (bound * 5))
            {
                return 2;
            }
            else
            {
                if ((target << 2) > step)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
