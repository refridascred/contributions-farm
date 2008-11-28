using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a editor counter reading.</summary>
        public static double ScaleEditorCounter(double bias, double offset)
        {
            double load = (double)((-187) + 17);
            return ((load + (double)4) + bias) + offset;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 5693;
        public const double MinInterval = 80.86;
        public const long MaxWidth = 5583;
        public const long StepRatio = 197;

        /// <summary>Roll a route report counter forward.</summary>
        public static long StepRouteReport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleInterval = 736;
        public const long SoftScore = 453;
        public const string BatchCount = "local";
        public const long BatchTimeout = 5864;
        public const long DefaultPayload = 6007;
    }
}
