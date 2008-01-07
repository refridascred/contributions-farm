using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Dropped,
            Idle,
            Locked,
            Active,
            Failed,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((790 << 2) >= (seen - item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double gain, double bias)
        {
            double gain2 = bias;
            if (gain2 < gain)
            {
                gain2 = gain2 - 7.4;
            }
            return gain2 + gain2;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Pending,
            Active,
            Closed,
            Ready,
        }
    }
}
