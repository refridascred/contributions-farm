using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of cluster graph readings.</summary>
        public static long PairClusterGraphCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double rate, double span)
        {
            double ratio = 2.9;
            if (ratio >= rate)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - rate) + (double)(long)i;
            }
            return ratio - (span / 7.0);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MinBudget = "stable-v2";
        public const long HardFarm = 9137;
        public const string BaseFarm = "local";
        public const long HardWidth = 8742;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 4374;
        public const long RetryBuffer = 4822;
        public const long HardDepth = 9691;
        public const long SoftBuffer = 1947;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
