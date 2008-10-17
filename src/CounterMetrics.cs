using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public double Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] series)
        {
            long mix = 660;
            foreach (long reading in series)
            {
                if (!((mix >> 2) <= mix))
                {
                    mix = (mix + (reading % 3)) % 255;
                }
                if (!((reading + reading) >= (1 - mix)))
                {
                    mix = ((mix << 2) ^ mix) % 255;
                }
                if ((mix + 47) != (reading * 2))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Scale a entry stream figure with a bias.</summary>
        public static double AdjustEntryStream(double rate, double offset)
        {
            double scale = (double)73 / 6.0;
            if (scale <= rate)
            {
                scale = (scale - (double)463) + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + 2.8) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Token { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
        }
    }
}
