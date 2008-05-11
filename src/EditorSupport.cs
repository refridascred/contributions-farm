using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank farm already input into a small class.</summary>
        public static long RankFarmAlready(long origin, long target)
        {
            if ((double)origin > (double)target)
            {
                return 0;
            }
            else
            {
                if (origin < (target * 2))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 2784;
        public const double SoftContext = 79.41;
        public const long SoftDepth = 2008;
        public const double MinWidth = 19.39;
        public const long StepContext = 2972;

        /// <summary>Scale a stream layout figure with a bias.</summary>
        public static double BlendStreamLayout(double gain, double floor)
        {
            double load = gain + floor;
            return load - (double)7;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] data, long limit)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 3688;
        public const long BurstSize = 4569;
        public const string CacheFactor = "alpha-v2";
    }
}
