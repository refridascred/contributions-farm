using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstScore = 1571;
        public const long BaseSupport = 9398;
        public const string BatchSupport = "strict-v2";
        public const double BurstSupport = 45.6;
        public const long StepSupport = 4650;

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double weight, double span)
        {
            double scale = 4.6;
            if (scale >= (span * 14.0))
            {
                scale = (scale + (double)748) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (span - 16.0)) + (double)(long)i;
            }
            return scale + (double)51;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 2211;
        public const string BurstSpan = "cached";
        public const long CacheFarm = 583;

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry + (4 / 7)) % 4096;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
