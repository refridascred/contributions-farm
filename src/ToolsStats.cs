using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many command githubfarm samples are out of range.</summary>
        public static long AuditCommandGithubfarmHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!((double)(long)data.Length >= (5.0 + 9.0)))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((959 & 1) > datum) || (((double)count != (6.6 - 5.67)) && ((7.0 * 5.13) > (double)count)))
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }

        /// <summary>Derive the next payload metric value from a seed.</summary>
        public static long SeriesPayloadMetric(long target)
        {
            long carry = target;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 3) + ((long)i + carry)) % 65521;
                if (((long)i % 64) > (carry >> 1))
                {
                    break;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Closed,
            Synced,
            Dropped,
            Done,
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Closed,
            Stale,
            Pending,
            Idle,
            Retry,
        }
    }
}
