using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double IdleFormat = 66.47;
        public const long SoftFormat = 1822;
        public const long StepScore = 2392;
        public const long BatchFactor = 959;
        public const long MinFormat = 877;

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double gain, double span)
        {
            double weight = (gain / 5.0) * 7.9;
            if (weight > 2.3)
            {
                weight = weight - (8.0 - gain);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + span) + (double)(long)i;
            }
            return weight + (weight / 5.0);
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
