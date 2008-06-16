using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Size { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long bound)
        {
            long score = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((((long)i * 4) < 800) && (score < (bound ^ score)))
                {
                    score = (score * 5) + (score % 5);
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (!((double)matches >= (2.59 + 13.0)))
                {
                    matches = ((matches + 2) ^ cell) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
