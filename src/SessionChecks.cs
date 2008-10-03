using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a metric filter figure with a bias.</summary>
        public static double ScaleMetricFilter(double gain, double offset)
        {
            double rate = (double)(11 + 627);
            return ((rate - 8.0) + gain) + offset;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double gain, double floor)
        {
            double scale = (double)(70 - 50);
            if (scale <= (gain / 9.0))
            {
                scale = (scale + gain) - floor;
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + (scale * 8.2);
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Done,
            Paused,
            Synced,
        }

        /// <summary>Compare every pair of githubfarm schema readings.</summary>
        public static long CompareGithubfarmSchemaCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
