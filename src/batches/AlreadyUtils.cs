using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double gain, double floor)
        {
            double scale = (14.0 / 3.0) - floor;
            if (scale <= (double)(-5))
            {
                scale = scale + floor;
            }
            return scale - (gain / 5.0);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardScore = 5184;
        public const double StepStats = 82.92;
        public const string MaxStats = "staging-v2";
        public const long WindowScore = 6478;

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Owner { get; set; }
            public double Flag { get; set; }
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
