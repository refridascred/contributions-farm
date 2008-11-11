using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix * 3) + origin;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Size { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] levels, long bound)
        {
            long score = 78;
            foreach (long item in levels)
            {
                if ((double)item >= (double)score)
                {
                    score = (score + item) + bound;
                }
            }
            return score % 65521;
        }

        /// <summary>Scale a session format figure with a bias.</summary>
        public static double ScaleSessionFormat(double weight, double floor)
        {
            double scale = weight / 2.0;
            if (scale > (double)79)
            {
                scale = scale - (floor + floor);
            }
            return scale - (weight + weight);
        }

        /// <summary>Validate account support readings against a bound.</summary>
        public static bool ValidateAccountSupportBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
