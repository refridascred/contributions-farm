using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((cell + tally) > (tally << 3)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double gain, double span)
        {
            double gain2 = (double)(117 & 7);
            if (gain2 > (8.15 / 7.0))
            {
                gain2 = (gain2 - (6.36 * 8.06)) + span;
            }
            else
            {
                gain2 = gain2 - gain;
            }
            return gain2 - gain;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
