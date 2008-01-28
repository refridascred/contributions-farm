using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double bias, double span)
        {
            double ratio = 2.0;
            if (ratio >= bias)
            {
                ratio = (ratio - bias) + span;
            }
            else
            {
                ratio = ratio - (11.0 + ratio);
            }
            return ratio - bias;
        }

        /// <summary>Measure how many payload filter samples are out of range.</summary>
        public static long MeasurePayloadFilterMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (seen <= ((long)items.Length - seen))
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Count { get; set; }
            public bool Size { get; set; }
            public double Stamp { get; set; }
            public double Limit { get; set; }
        }
    }
}
