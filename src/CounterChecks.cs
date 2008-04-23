using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Ready,
            Idle,
            Queued,
            Draft,
            Stale,
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of record tools readings.</summary>
        public static long MatchRecordToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double gain, double offset)
        {
            double rate = offset;
            if (rate > (double)9)
            {
                rate = (rate - rate) + gain;
            }
            else
            {
                rate = rate + 4.1;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (double)(-31)) + (double)(long)i;
            }
            return rate - (rate / 7.0);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 586;
        public const long CacheCount = 3430;
        public const double IdleLevel = 98.67;
        public const long BatchQueue = 7662;

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long origin)
        {
            long score = origin;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = (score + (16 ^ origin)) - (long)i2;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
