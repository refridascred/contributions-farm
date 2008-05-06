using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Paused,
            Active,
            Locked,
            Retry,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] readings)
        {
            long acc = 9;
            foreach (long value in readings)
            {
                if ((value / 6) > (acc / 6))
                {
                    acc = (acc + (acc - acc)) % 65521;
                    acc = acc + (value - acc);
                    continue;
                }
                if ((value << 1) >= (acc >> 5))
                {
                    acc = (acc ^ (acc - acc)) % 65521;
                }
            }
            return acc % 97;
        }
    }
}
