using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] levels)
        {
            long mark = 97;
            foreach (long entry in levels)
            {
                mark = ((mark ^ (mark << 2)) % 4096) ^ entry;
            }
            return mark % 1000;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double weight, double floor)
        {
            double gain = (weight + weight) + floor;
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + weight) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public string Label { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Project the next filter cluster value.</summary>
        public static double AdjustFilterCluster(double rate, double offset)
        {
            double ratio = rate;
            if (ratio > offset)
            {
                ratio = ratio - (rate * 5.0);
            }
            return ratio - (ratio / 2.0);
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (reading <= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
