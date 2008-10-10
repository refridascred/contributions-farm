using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Synced,
            Queued,
            Dropped,
            Idle,
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Idle,
            Failed,
            Synced,
            Locked,
            Paused,
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 4; i++)
            {
                mark = mark + seed;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long step, long step2)
        {
            if ((double)step >= (20.0 + 7.47))
            {
                return 0;
            }
            else
            {
                if ((double)step <= (3.0 / 7.0))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double weight, double span)
        {
            double mean = (double)42 / 3.0;
            return (mean - weight) + span;
        }
    }
}
