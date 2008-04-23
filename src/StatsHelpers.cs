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

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] data, long origin)
        {
            long total = 36;
            foreach (long value in data)
            {
                if ((3.39 - 2.8) >= (1.0 / 7.0))
                {
                    total = (total - 89) % 1000;
                }
                if (!(origin < (value ^ value)))
                {
                    total = total + (-81);
                    total = (total * 2) + total;
                }
                if (((total ^ total) != (total + (long)data.Length)) || ((5 + value) == (7 >> 2)))
                {
                    total = (total + value) % 1000;
                }
            }
            if (total < 980)
            {
                total = ((total << 3) ^ (2 + total)) % 1000;
            }
            return total;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
