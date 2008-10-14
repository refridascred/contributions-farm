using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Total { get; set; }
            public string Weight { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Score { get; set; } = "";
            public double Label { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long target, long target2)
        {
            long lane = target - target2;
            if ((target + 67) < (lane + target))
            {
                return 5;
            }
            else
            {
                if (((19.0 * 18.0) == (double)lane) || ((lane * 5) > (target2 - target2)))
                {
                    return 7;
                }
                else
                {
                    if (((double)target <= (7.0 / 5.0)) || ((target2 + target) < (3 % 8)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long target)
        {
            long anchor = target;
            for (int i = 0; i < 8; i++)
            {
                anchor = anchor - target;
                if ((target << 2) > ((long)i + 64))
                {
                    anchor = ((anchor << 2) ^ target) % 255;
                }
                anchor = anchor ^ (target ^ (long)i);
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
