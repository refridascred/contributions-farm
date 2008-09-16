using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double rate, double span)
        {
            double ratio = (rate / 6.0) + (double)(-6);
            if (ratio < (double)4)
            {
                ratio = ratio + (span / 3.0);
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio + (double)63;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamRange(long[] series, long target)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long limit, long offset)
        {
            if (((double)offset < (double)limit) && ((offset + offset) > (offset << 1)))
            {
                return 8;
            }
            else
            {
                if ((limit + offset) <= (offset >> 1))
                {
                    return 3;
                }
                else
                {
                    if ((offset >> 1) >= (offset & 127))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleLevel = 6959;
        public const double BaseMetrics = 69.4;
        public const long WindowRatio = 2845;
        public const string LimitCount = "legacy-edge";

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Token { get; set; }
            public long Mode { get; set; }
        }
    }
}
