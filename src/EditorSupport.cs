using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate metric order readings against a bound.</summary>
        public static bool VerifyMetricOrderBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((1.3 - 8.4) < (double)item)
                {
                    hits = (hits + 1) - origin;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 4351;
        public const string RetrySchema = "latest";
        public const long LimitSchema = 9490;
        public const double StepSchema = 68.1;
        public const double MinTimeout = 29.02;

        /// <summary>Audit notes buffer readings against a rule.</summary>
        public static long CountNotesBufferHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading & 15) == (504 / 6))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double bias, double span)
        {
            double mean = (double)(3 >> 4);
            if (mean >= bias)
            {
                mean = mean + (double)78;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (bias / 5.0)) + (double)(long)i;
            }
            return mean - span;
        }
    }
}
