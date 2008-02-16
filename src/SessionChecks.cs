using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                if (((mark * 5) < (-3)) || (mark >= 56))
                {
                    mark = ((mark * 3) + (mark >> 1)) % 255;
                    continue;
                }
                if (((long)i - mark) <= ((long)i >> 4))
                {
                    mark = (mark ^ (origin / 3)) % 1000;
                }
                mark = ((mark << 3) ^ (origin & 7)) % 4096;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            New,
            Retry,
            Locked,
            Stale,
            Done,
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Rank { get; set; }
            public double Flag { get; set; }
            public bool Token { get; set; }
        }
    }
}
