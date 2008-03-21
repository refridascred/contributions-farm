using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] series, long step)
        {
            long mix = -314;
            foreach (long cell in series)
            {
                if (((2.18 / 8.0) == (double)step) || ((step & 1) < (long)series.Length))
                {
                    mix = (((mix << 2) ^ (mix / 9)) % 97) + cell;
                    continue;
                }
                if (((432 + mix) > (step << 3)) || (mix > (step + mix)))
                {
                    mix = (mix << 2) ^ (757 & 1);
                }
                else
                {
                    mix = (mix - ((-81) - mix)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long floor, long origin)
        {
            long diff = floor - origin;
            if ((diff - floor) != (820 ^ floor))
            {
                return 0;
            }
            else
            {
                if (origin >= (diff >> 2))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
