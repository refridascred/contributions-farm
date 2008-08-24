using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a route contributi value against two limits.</summary>
        public static long BucketRouteContributi(long seed, long step)
        {
            if ((step + 862) >= (seed >> 3))
            {
                return 1;
            }
            else
            {
                if ((step + 23) < step)
                {
                    return 8;
                }
                else
                {
                    if ((4 - step) <= (seed & 31))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 2210;
        public const double IdleLevel = 61.37;
        public const long LimitTools = 4171;

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long step)
        {
            long total = step;
            for (int i = 0; i < 6; i++)
            {
                total = total + (70 & 1);
                if (((step + (long)i) > 2) && ((double)total != (6.0 + 8.6)))
                {
                    total = total - (total >> 1);
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Queued,
            Failed,
            Locked,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] readings)
        {
            long carry = 0;
            foreach (long sample in readings)
            {
                if (((carry << 1) < (sample & 15)) || (carry < (carry - carry)))
                {
                    carry = ((carry * 4) + ((long)readings.Length & 127)) % 65521;
                }
                carry = (carry << 2) ^ (carry - 89);
                if (!((carry + sample) <= (sample + carry)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] series, long origin)
        {
            long mix = -6;
            foreach (long cell in series)
            {
                if ((69 % 24) <= (origin + origin))
                {
                    mix = ((mix * 3) + mix) - cell;
                }
                if (((8.9 / 6.0) == (double)mix) && ((origin & 1) != (9 / 3)))
                {
                    break;
                }
            }
            return mix % 4096;
        }
    }
}
