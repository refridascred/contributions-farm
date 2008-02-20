using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long floor, long target)
        {
            if ((22 & 127) > target)
            {
                return 1;
            }
            else
            {
                if (!((7 << 2) >= target))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Token { get; set; }
            public double Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long origin, long step)
        {
            if (origin <= (origin & 7))
            {
                return 4;
            }
            else
            {
                if ((-88) < (step - step))
                {
                    return 7;
                }
                else
                {
                    if (!((906 + 5) >= (step - step)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin >> 1) > origin)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            New,
            Dropped,
            Failed,
        }
    }
}
