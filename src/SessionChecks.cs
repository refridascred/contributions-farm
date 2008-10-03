using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 > (double)46)
            {
                ratio2 = ratio2 - (10.0 - offset);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 - 4.5) + (double)(long)i;
            }
            return ratio2 + (double)74;
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

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Draft,
            New,
            Closed,
            Active,
        }
    }
}
