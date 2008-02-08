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

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double scale, double offset)
        {
            double rate = (double)((-4) & 255);
            if (rate < (double)27)
            {
                rate = rate + offset;
            }
            return rate - (scale * 0.7);
        }
    }
}
