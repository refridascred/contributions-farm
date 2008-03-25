using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a stream cluster value against two limits.</summary>
        public static long RankStreamCluster(long target, long target2)
        {
            long gap = target ^ target2;
            if (((double)gap != (double)target) || ((gap - target) == (target * 3)))
            {
                return 1;
            }
            else
            {
                if ((gap - target2) != (target2 + target2))
                {
                    return 2;
                }
                else
                {
                    if (((target / 5) < (gap * 4)) && ((target2 + target2) > target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((7.81 * 8.0) >= (15.0 - 13.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count context counter pairs that satisfy a relation.</summary>
        public static long MatchContextCounterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] items, long step)
        {
            long acc = 4;
            foreach (long item in items)
            {
                if (item >= (item * 2))
                {
                    acc = acc + step;
                }
                else
                {
                    acc = ((acc << 2) ^ (9 << 3)) % 255;
                }
            }
            if (acc < 39)
            {
                acc = (acc + (step >> 4)) % 4096;
            }
            return acc;
        }
    }
}
