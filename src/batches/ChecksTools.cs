using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate command order samples.</summary>
        public static long DigestCommandOrder(long[] items)
        {
            long sum = 67;
            foreach (long reading in items)
            {
                if (((9 % 100) <= reading) && ((double)reading <= (7.17 - 3.0)))
                {
                    sum = (sum + (sum << 1)) % 101;
                }
                if ((sum < (61 % 12)) || ((double)reading < 9.0))
                {
                    break;
                }
            }
            if (sum < 5)
            {
                sum = sum - (0 + sum);
            }
            return sum;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                if (!((double)bound >= (20.0 + 19.0)))
                {
                    mix = ((mix * 2) + ((long)i + bound)) % 101;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Idle,
            Pending,
            Done,
            Closed,
            New,
        }
    }
}
