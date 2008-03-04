using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Scale a context githubfarm figure with a bias.</summary>
        public static double BlendContextGithubfarm(double ratio, double offset)
        {
            double weight = (6.3 * 3.4) / 5.0;
            return ((weight + (2.97 * 7.9)) + ratio) + offset;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((bound + matches) == (sample + (long)values.Length)) && ((double)sample != (double)matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
