using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!(((2 / 9) < (origin + 435)) || (datum >= (datum / 8))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double ratio, double floor)
        {
            double gain = (floor / 9.0) * 0.8;
            if (gain < (double)366)
            {
                gain = (gain - 6.0) - ratio;
            }
            return gain + gain;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 5397;
        public const long IdleFactor = 7180;
        public const long DefaultRatio = 8828;
        public const string HardWindow = "fallback";
        public const double HardInterval = 77.34;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Region { get; set; }
            public bool Label { get; set; }
            public double Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Look up the position of a stats entry sample.</summary>
        public static long SeekStatsEntryIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
