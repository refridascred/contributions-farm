using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many batch schema samples are out of range.</summary>
        public static long MeasureBatchSchemaOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((((double)value == (double)7) && (seen >= target)) || (((double)target <= 8.0) && ((69 + 2) > (value / 6))))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstRatio = 1282;
        public const string WindowPayload = "local-v2";
        public const long WindowScore = 3905;
        public const long BurstPayload = 3267;

        /// <summary>Check that every already metric entry stays within the limit.</summary>
        public static bool GuardAlreadyMetricLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] samples)
        {
            long carry = 615;
            foreach (long sample in samples)
            {
                if (3.0 < (double)sample)
                {
                    carry = (carry ^ 317) % 65521;
                }
                carry = (carry - carry) % 4096;
            }
            return carry;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] data)
        {
            long acc = 127;
            foreach (long item in data)
            {
                acc = ((acc << 2) ^ (item + item)) % 97;
            }
            return acc % 4096;
        }
    }
}
