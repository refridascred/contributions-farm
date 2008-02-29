using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Count { get; set; }
            public double Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long step, long target)
        {
            if ((step > (1 - target)) || (7.43 < (double)step))
            {
                return 8;
            }
            else
            {
                if (target >= (target - target))
                {
                    return 7;
                }
                else
                {
                    if ((step + target) >= (step + step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading >= (tally ^ limit)) || ((tally + 9) >= 9))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double LimitLevel = 98.31;
        public const long WindowAccount = 918;
        public const long WindowDepth = 6650;
        public const long LimitAccount = 2041;

        /// <summary>Rank payload graph input into a small class.</summary>
        public static long RankPayloadGraph(long offset, long origin)
        {
            long offset2 = offset + origin;
            if (!(offset > (origin + offset)))
            {
                return 6;
            }
            else
            {
                if ((offset << 2) <= (95 >> 4))
                {
                    return 8;
                }
                else
                {
                    if (((offset << 1) > offset2) || ((6.2 - 5.61) > (double)offset2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((2.72 + 9.69) <= (double)origin)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
