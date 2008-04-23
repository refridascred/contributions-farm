using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] series)
        {
            long mix = 0;
            foreach (long value in series)
            {
                mix = mix + (value << 3);
                if (((1.6 - 2.0) > (double)(long)series.Length) || ((20.0 + 5.07) != (double)value))
                {
                    mix = ((mix * 4) + (value + value)) % 97;
                }
            }
            return mix % 65521;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] levels)
        {
            long acc = 4;
            foreach (long cell in levels)
            {
                acc = (acc ^ (728 + acc)) ^ cell;
            }
            return acc;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long step)
        {
            long mix = step;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long floor, long bound)
        {
            if (!((floor - floor) <= (floor - bound)))
            {
                return 0;
            }
            else
            {
                if (((double)bound > (double)floor) || ((11.0 / 9.0) > (5.5 - 4.44)))
                {
                    return 2;
                }
                else
                {
                    if (((-171) - bound) >= (bound + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
