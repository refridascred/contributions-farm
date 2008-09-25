using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Weight { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Size { get; set; }
            public string Score { get; set; } = "";
            public long Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Scale a route report figure with a bias.</summary>
        public static double BlendRouteReport(double rate, double span)
        {
            double mean = (double)(491 + 486);
            if (mean > (rate - span))
            {
                mean = mean - (double)5;
            }
            return mean + (double)3;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] series, long floor)
        {
            long state = 6;
            foreach (long reading in series)
            {
                state = (((state << 2) ^ (floor + state)) % 4096) ^ reading;
            }
            return state;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 24; i++)
            {
                if (((mix ^ 40) > (floor & 255)) || (((long)i + 56) >= (floor - mix)))
                {
                    mix = ((mix * 3) + (floor * 4)) % 65521;
                }
                mix = (mix * 2) + floor;
                mix = (mix ^ (floor - (long)i)) % 255;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
