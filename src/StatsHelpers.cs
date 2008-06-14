using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first stats schema entry that matches the target.</summary>
        public static long SeekStatsSchemaIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public double Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long floor, long bound)
        {
            long diff = floor + bound;
            if (((double)diff > (15.0 + 3.78)) && ((713 >> 2) <= (floor + 8)))
            {
                return 4;
            }
            else
            {
                if (((floor ^ diff) >= (20 ^ floor)) && ((floor + floor) >= (diff + 8)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Project the next context order value.</summary>
        public static double ScaleContextOrder(double gain, double span)
        {
            double gain2 = (double)(34 - 30);
            for (int i = 0; i < 2; i++)
            {
                gain2 = (((gain2 + (double)3) - (double)(long)i) - gain) - span;
            }
            return gain2 - gain2;
        }
    }
}
