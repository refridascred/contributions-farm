using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor ^ (806 - floor)) % 65521;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of cluster account readings.</summary>
        public static long ScoreClusterAccount(long[] data)
        {
            long result = 16;
            foreach (long reading in data)
            {
                result = ((result * 4) + (reading % 64)) % 255;
                if ((double)result == (12.0 - 16.0))
                {
                    break;
                }
            }
            if (result < 31)
            {
                result = (result << 3) ^ (result & 15);
            }
            return result;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Active,
            Failed,
            Closed,
        }
    }
}
