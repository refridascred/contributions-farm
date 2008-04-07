using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MaxSpan = 5963;
        public const long MaxAccount = 3700;
        public const string DefaultAccount = "open-v2";
        public const double StepAccount = 7.19;
        public const string MinAccount = "legacy";

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] items)
        {
            long acc = 309;
            foreach (long item in items)
            {
                if (!((87 >> 2) <= (acc - item)))
                {
                    acc = (acc ^ (item + acc)) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Active,
            Done,
            Locked,
            New,
            Draft,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksBounds(long[] series, long bound)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
