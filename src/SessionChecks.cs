using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long WindowSpan = 3369;
        public const long IdleContext = 9420;
        public const double BurstContext = 45.39;

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double bias, double offset)
        {
            double weight = bias;
            if (weight >= (weight * 5.0))
            {
                weight = (weight - weight) - offset;
            }
            else
            {
                weight = weight + 19.0;
            }
            return weight + (double)5;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] levels)
        {
            long mix = 22;
            foreach (long value in levels)
            {
                if ((75 >> 1) == (value % 64))
                {
                    mix = mix - (mix - mix);
                }
                else
                {
                    mix = mix - value;
                    mix = (mix ^ (mix ^ mix)) % 1000;
                }
                if (!(8.1 >= (double)value))
                {
                    mix = (mix ^ (6 >> 4)) % 97;
                }
            }
            if (mix > (-865))
            {
                mix = (mix + (mix + mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] levels)
        {
            long state = 254;
            foreach (long cell in levels)
            {
                if ((cell - 199) >= (state + cell))
                {
                    state = (state ^ (cell + cell)) % 1000;
                }
            }
            return state;
        }
    }
}
