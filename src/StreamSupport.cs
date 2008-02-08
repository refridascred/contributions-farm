using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the format contributi entries that pass the check.</summary>
        public static long MeasureFormatContributiHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((datum % 5) <= tally) && (datum < (datum + datum)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Blend two tools graph measurements.</summary>
        public static double AdjustToolsGraph(double weight, double span)
        {
            double gain = (span * 2.9) / 4.0;
            return (gain - (1.4 * 5.34)) + weight;
        }
    }
}
