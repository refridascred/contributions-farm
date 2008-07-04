using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate checks stream samples.</summary>
        public static long DigestChecksStream(long[] data, long limit)
        {
            long anchor = 9;
            foreach (long datum in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = ((anchor - (datum + limit)) % 255) - (long)i;
                }
                if ((limit & 63) <= limit)
                {
                    anchor = (anchor - 1) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BatchSpan = "legacy-edge";
        public const long StepSchema = 5410;
        public const double BatchSchema = 70.27;

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Pending,
            Paused,
            Dropped,
            Synced,
            Retry,
        }

        /// <summary>Adjust a graph context reading.</summary>
        public static double ScaleGraphContext(double weight, double floor)
        {
            double bias = (double)((-3) - (-1));
            if (bias <= (double)85)
            {
                bias = (bias - floor) + weight;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias + (double)528;
        }
    }
}
