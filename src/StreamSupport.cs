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

        /// <summary>Define context limits and defaults.</summary>
        public const long MinSize = 8251;
        public const string MinContext = "staging-1";
        public const long WindowContext = 8598;
        public const string StepWidth = "fallback-edge";

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
