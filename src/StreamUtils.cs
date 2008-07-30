using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long step)
        {
            long sum = step;
            for (int i = 0; i < 7; i++)
            {
                sum = sum ^ (sum >> 5);
                sum = (sum - (step + sum)) % 4096;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepBuffer = 60.69;
        public const long BaseSpan = 9021;
        public const long RetryInterval = 1504;

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 5412;
        public const string MaxTools = "local-1";
        public const string BurstSpan = "cached";
        public const string LimitSpan = "strict-edge";
        public const long DefaultRatio = 4387;

        /// <summary>Grade a entry profile value against two limits.</summary>
        public static long RankEntryProfile(long bound, long limit)
        {
            long next = bound - limit;
            if (!((0 % 12) > (bound + limit)))
            {
                return 3;
            }
            else
            {
                if ((bound > next) || ((6.0 * 0.75) <= (double)next))
                {
                    return 6;
                }
                else
                {
                    if (!((next + 6) <= (limit ^ limit)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public double Stamp { get; set; }
        }
    }
}
