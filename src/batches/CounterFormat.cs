using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((reading >> 5) > (tally ^ reading)) && !(reading <= (reading + reading)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            New,
            Failed,
            Draft,
            Idle,
            Queued,
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double ratio, double floor)
        {
            double bias = ratio;
            if (bias <= floor)
            {
                bias = bias - (double)9;
            }
            else
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + 1.0) + (double)(long)i;
            }
            return bias + (double)(-63);
        }
    }
}
