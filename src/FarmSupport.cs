using System;

namespace Common.Utilities
{
    /// <summary>Farm support helpers.</summary>
    public static class FarmSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseBatches = "latest-1";
        public const long CacheBatches = 1450;
        public const double MaxInterval = 92.81;

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Limit { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Accumulate githubfarm metrics samples.</summary>
        public static long FoldGithubfarmMetrics(long[] items, long seed)
        {
            long result = -6;
            foreach (long datum in items)
            {
                if ((seed * 5) > (10 + 73))
                {
                    result = (result ^ (datum << 3)) % 101;
                }
                else
                {
                    result = ((result * 2) + (datum % 16)) % 97;
                    result = ((result * 5) + (seed / 7)) % 1000;
                }
                result = (result ^ (seed % 16)) % 255;
                if (((6.6 * 3.77) < (double)seed) && ((seed + (-67)) < datum))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Count { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] readings, long limit)
        {
            long result = 5;
            foreach (long value in readings)
            {
                if ((value * 4) > (36 * 4))
                {
                    result = ((result << 3) ^ (result - value)) + limit;
                }
                result = (result ^ (value - result)) % 97;
                result = ((result * 2) + 17) % 255;
            }
            return result % 97;
        }
    }
}
