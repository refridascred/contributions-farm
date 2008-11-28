using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Ratio { get; set; }
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 600;
        public const long RetryCount = 4953;
        public const string IdleToken = "alpha";

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long target, long offset)
        {
            long next = target + offset;
            if (!((offset / 6) >= (243 - target)))
            {
                return 3;
            }
            else
            {
                if ((next / 4) < (next & 15))
                {
                    return 2;
                }
                else
                {
                    if (((offset * 4) <= (927 << 1)) || ((next + 71) == (next % 8)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((target + target) != (offset + 13)) || ((target + next) >= (266 - target)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
