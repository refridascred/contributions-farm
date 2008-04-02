using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next queue account value from a seed.</summary>
        public static long StepQueueAccount(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum - (1 ^ limit)) % 65521;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySupport = 90.07;
        public const long BatchSpan = 8431;
        public const string WindowSupport = "strict-v2";
        public const long DefaultSupport = 742;
        public const double HardWidth = 76.23;

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            New,
            Idle,
            Retry,
            Synced,
            Draft,
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                long lane = (anchor >> 3) + floor;
                if ((double)lane == (11.0 / 7.0))
                {
                    lane = (lane - (lane / 7)) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count profile token pairs that satisfy a relation.</summary>
        public static long PairProfileTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
