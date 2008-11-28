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

        /// <summary>Audit editor context readings against a rule.</summary>
        public static long MeasureEditorContextHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)cell < (7.9 * 14.0))
                {
                    count = count + 1;
                }
            }
            return count;
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

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double scale, double offset)
        {
            double bias = (double)604 - scale;
            for (int i = 0; i < 8; i++)
            {
                bias = ((bias + (7.8 + 17.0)) + (double)(long)i) + offset;
            }
            return bias - (double)1;
        }
    }
}
