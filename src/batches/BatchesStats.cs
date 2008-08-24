using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Stale,
            Draft,
            New,
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Stale,
            Ready,
            Draft,
            Failed,
            Active,
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double gain, double offset)
        {
            double scale = (double)(726 >> 3);
            if (scale > scale)
            {
                scale = scale + 8.9;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - offset) + (double)(long)i;
            }
            return scale - gain;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double LimitSpan = 74.99;
        public const long WindowReport = 2949;
        public const long MinLevel = 8703;
        public const double CacheReport = 59.62;
    }
}
