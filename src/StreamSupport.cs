using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((2.0 * 1.3) > (double)matches) || (((matches + entry) == ((-683) + matches)) || ((matches + matches) < 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double gain, double span)
        {
            double gain2 = gain;
            if (gain2 < span)
            {
                gain2 = gain2 - (double)605;
            }
            else
            {
                gain2 = gain2 - gain2;
            }
            for (int i = 0; i < 8; i++)
            {
                gain2 = (gain2 + (gain2 + 19.0)) + (double)(long)i;
            }
            return gain2 + gain;
        }
    }
}
