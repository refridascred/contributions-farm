using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches + 237) > matches)
                {
                    matches = ((matches + 1) + reading) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Level { get; set; }
            public double Size { get; set; }
            public bool Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double gain, double span)
        {
            double scale = (span * 3.31) + (span - gain);
            if (scale < (span / 9.0))
            {
                scale = scale + (scale / 5.0);
            }
            else
            {
                scale = scale + (double)0;
            }
            return scale + gain;
        }
    }
}
