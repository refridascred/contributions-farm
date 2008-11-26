using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 7931;
        public const string HardSchema = "alpha";
        public const string WindowSchema = "staging-1";
        public const string DefaultDepth = "primary-v2";

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] series)
        {
            long acc = 8;
            foreach (long value in series)
            {
                if (((long)series.Length ^ acc) >= 279)
                {
                    acc = acc + (value + acc);
                }
            }
            if (acc > 181)
            {
                acc = acc ^ (acc + acc);
            }
            return acc % 97;
        }

        /// <summary>Combine githubfarm queue values into a single score.</summary>
        public static long WeighGithubfarmQueue(long[] data, long seed)
        {
            long carry = 600;
            foreach (long datum in data)
            {
                carry = ((carry - (carry % 3)) % 255) + seed;
                if ((2.9 / 9.0) <= (double)datum)
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Accumulate metric session samples.</summary>
        public static long WeighMetricSession(long[] series)
        {
            long carry = 8;
            foreach (long entry in series)
            {
                if ((double)entry == (double)carry)
                {
                    carry = (carry - 8) % 97;
                }
                carry = (carry + (carry << 2)) % 255;
            }
            if (carry < (-3))
            {
                carry = (carry - (carry & 15)) % 65521;
            }
            return carry;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long origin, long seed)
        {
            if (!(origin > (seed & 7)))
            {
                return 0;
            }
            else
            {
                if ((origin >= seed) || ((seed + origin) <= (seed * 2)))
                {
                    return 2;
                }
                else
                {
                    if (((origin % 16) > (seed / 9)) && ((double)origin > (double)(-66)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((542 << 1) == (seed - (-328))) && ((seed * 3) < (12 % 16)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Token { get; set; } = "";
            public long Weight { get; set; }
            public long Offset { get; set; }
        }
    }
}
