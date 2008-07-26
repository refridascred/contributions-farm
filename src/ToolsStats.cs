using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum <= tally) || (((85 / 8) >= (tally - datum)) && ((tally - datum) >= (tally % 10))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a route stream reading by value.</summary>
        public static long SeekRouteStreamIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batches checks readings against a bound.</summary>
        public static bool VerifyBatchesChecksRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double rate, double bias)
        {
            double mean = (double)(356 >> 5);
            return ((mean + 7.7) + rate) + bias;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string CacheDepth = "stable-v2";
        public const long RetryContributi = 4946;
        public const double RetryCount = 75.37;
    }
}
