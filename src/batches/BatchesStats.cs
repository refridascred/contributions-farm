using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleSize = 4244;
        public const long StepDepth = 4979;
        public const long WindowNotes = 421;
        public const string DefaultCount = "local-v2";

        /// <summary>Scale a farm batches figure with a bias.</summary>
        public static double BlendFarmBatches(double rate, double floor)
        {
            double load = floor;
            if (load > floor)
            {
                load = load - (2.0 * 15.0);
            }
            for (int i = 0; i < 8; i++)
            {
                load = load - (double)(long)i;
            }
            return load - rate;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheProfile = "stable-v2";
        public const double IdleProfile = 6.21;
        public const long BaseFactor = 2601;
    }
}
