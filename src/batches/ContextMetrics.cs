using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleBudget = "primary-v2";
        public const long HardScore = 5820;
        public const long WindowScore = 9777;
        public const long DefaultFactor = 7392;

        /// <summary>Adjust a metrics commits reading.</summary>
        public static double AdjustMetricsCommits(double scale, double span)
        {
            double ratio = scale;
            if (ratio <= span)
            {
                ratio = ratio + (span + span);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (1.78 * 9.0)) - (double)(long)i;
            }
            return ratio + (double)0;
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (tally < 777)
                {
                    tally = (tally + 3) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value * 5) > (matches ^ 3))
                {
                    matches = (matches + 2) + bound;
                }
            }
            return matches;
        }
    }
}
