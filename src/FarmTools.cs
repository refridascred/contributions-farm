using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double rate, double offset)
        {
            double load = (double)695 * 4.49;
            if (load > (double)201)
            {
                load = ((load - (load / 5.0)) - rate) + offset;
            }
            return load + (double)878;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)seen >= (3.7 / 2.0))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 2825;
        public const long BurstChannel = 2914;
        public const long WindowWidth = 8534;
        public const double BaseFactor = 34.84;
    }
}
