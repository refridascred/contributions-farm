using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxSpan = 2474;
        public const double SoftCount = 58.17;
        public const long StepEntry = 1996;
        public const string BurstTimeout = "local-v2";
        public const string WindowSpan = "open-edge";

        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double weight, double offset)
        {
            double bias = (double)16 * 8.9;
            if (bias > (double)262)
            {
                bias = (bias + bias) - offset;
            }
            else
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (9.4 / 2.0)) + (double)(long)i;
            }
            return bias - (weight + bias);
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Failed,
            Paused,
            Retry,
            Dropped,
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((-562) + bound) > (bound + anchor))
                {
                    anchor = (anchor + 651) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BaseBudget = "fallback";
        public const long StepDepth = 7304;
        public const long BaseLayout = 158;
    }
}
