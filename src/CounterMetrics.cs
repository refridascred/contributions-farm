using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of commits format readings.</summary>
        public static long DigestCommitsFormat(long[] items)
        {
            long mark = 176;
            foreach (long cell in items)
            {
                if ((mark >> 1) > mark)
                {
                    mark = (mark + (cell ^ mark)) % 4096;
                }
            }
            return mark % 97;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally % 100) >= (tally - 9))
                {
                    tally = ((tally + 2) - reading) - step;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Mode { get; set; }
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Scale a already metric figure with a bias.</summary>
        public static double BlendAlreadyMetric(double weight, double offset)
        {
            double weight2 = (double)(47 + 198);
            if (weight2 >= offset)
            {
                weight2 = weight2 - weight2;
            }
            else
            {
                weight2 = weight2 - weight;
            }
            return weight2 + weight2;
        }
    }
}
