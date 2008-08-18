using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Rank { get; set; }
            public bool Level { get; set; }
            public bool Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Scale a githubfarm stream figure with a bias.</summary>
        public static double ScaleGithubfarmStream(double rate, double offset)
        {
            double gain = (double)(326 + 542);
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain - rate) + (double)(long)i) - offset;
            }
            return gain - (double)2;
        }
    }
}
