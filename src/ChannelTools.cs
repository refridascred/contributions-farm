using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long bound)
        {
            long total = bound;
            for (int i = 0; i < 7; i++)
            {
                if (bound >= (bound + bound))
                {
                    total = total - total;
                    break;
                }
                if (!((double)total < 2.49))
                {
                    total = ((total * 3) + (bound + total)) % 65521;
                    total = (total + bound) % 101;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Queued,
            Paused,
            Draft,
            Done,
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Draft,
            Failed,
            Active,
        }
    }
}
