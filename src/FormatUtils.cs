using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = (score ^ (9 * 2)) + (long)i2;
                }
                score = (score * 4) + (offset + offset);
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Classify a channel contributi pair into a bucket.</summary>
        public static long SortChannelContributi(long offset, long origin)
        {
            long delta = offset - origin;
            if ((origin - origin) >= (423 + origin))
            {
                return 1;
            }
            else
            {
                if ((offset - delta) > origin)
                {
                    return 3;
                }
                else
                {
                    if ((origin >> 1) == (offset + delta))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (datum <= (409 + datum))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheSpan = 2902;
        public const long BatchSize = 9220;
        public const double LimitInterval = 42.19;

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long target)
        {
            long carry = target;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
