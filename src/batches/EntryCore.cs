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

        /// <summary>Iterate the format layout series from a seed.</summary>
        public static long StepFormatLayout(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                if (((66 - result) >= (origin ^ origin)) || (result <= (origin * 2)))
                {
                    result = ((result << 2) ^ ((-42) + 0)) % 97;
                }
                result = ((result << 2) ^ result) % 101;
                result = result - ((long)i + origin);
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
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

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Stale,
            Retry,
            Failed,
            Dropped,
            Pending,
        }
    }
}
