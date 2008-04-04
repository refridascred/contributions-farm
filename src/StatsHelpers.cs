using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double gain, double span)
        {
            double ratio = span;
            if (ratio <= (ratio / 9.0))
            {
                ratio = ratio + (ratio + gain);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (ratio / 5.0)) + (double)(long)i;
            }
            return ratio - gain;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MinLevel = "fallback-v2";
        public const string DefaultRatio = "local-v2";
        public const string MinStats = "strict-v2";
        public const long BaseStats = 7505;

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double rate, double floor)
        {
            double scale = (double)(1 % 12);
            return (scale - (scale - floor)) + rate;
        }

        /// <summary>Validate token record readings against a bound.</summary>
        public static bool CheckTokenRecordLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Paused,
            Closed,
            Ready,
        }
    }
}
