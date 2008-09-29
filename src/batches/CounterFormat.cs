using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long target, long step)
        {
            long step2 = target ^ step;
            if ((35 >= (step2 >> 4)) || ((step ^ step2) > step))
            {
                return 1;
            }
            else
            {
                if ((target + target) > (step - step))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long step)
        {
            long mark = step;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
            public double Mode { get; set; }
        }
    }
}
