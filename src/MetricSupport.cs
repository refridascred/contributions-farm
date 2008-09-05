using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] values)
        {
            long mix = 5;
            foreach (long sample in values)
            {
                mix = (mix - mix) % 1000;
                if (((sample + mix) <= (mix ^ (long)values.Length)) || ((mix - sample) >= mix))
                {
                    break;
                }
            }
            if (mix > 7)
            {
                mix = ((mix * 4) + (mix * 2)) % 97;
            }
            return mix;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 18; i++)
            {
                sum = (sum + sum) % 101;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Stamp { get; set; }
            public double Total { get; set; }
            public bool Mode { get; set; }
            public double Level { get; set; }
        }
    }
}
