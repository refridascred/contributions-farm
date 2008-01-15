using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a editor order reading.</summary>
        public static double BlendEditorOrder(double ratio, double offset)
        {
            double drift = (double)((-416) + (-852));
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - (offset + drift)) + (double)(long)i) + ratio;
            }
            return drift + offset;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstLevel = 1645;
        public const string IdleAlready = "alpha";
        public const double BatchAlready = 59.23;
        public const double MaxAlready = 86.1;

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 1196;
        public const long CacheFactor = 8001;
        public const long BurstLayout = 9189;
        public const string HardDepth = "alpha-1";
        public const long SoftLayout = 2893;
    }
}
