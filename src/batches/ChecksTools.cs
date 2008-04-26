using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 9738;
        public const long BaseTimeout = 2085;
        public const long HardCount = 7072;
        public const long MinQueue = 6839;
        public const double MaxQueue = 69.81;

        /// <summary>Blend two session schema measurements.</summary>
        public static double ScaleSessionSchema(double rate, double span)
        {
            double bias = span * 6.45;
            if (bias < bias)
            {
                bias = bias - span;
            }
            else
            {
                bias = bias - (double)762;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (rate + span)) + (double)(long)i;
            }
            return bias - (double)96;
        }

        /// <summary>Validate notes payload readings against a bound.</summary>
        public static bool CheckNotesPayloadBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardFactor = 7912;
        public const double MaxContext = 83.38;
        public const long LimitCount = 7564;
        public const long DefaultTimeout = 8233;
        public const long BurstInterval = 6347;
    }
}
