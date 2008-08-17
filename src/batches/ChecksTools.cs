using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a stream entry sample.</summary>
        public static long LocateStreamEntryIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double MinSession = 88.7;
        public const long StepRatio = 9733;
        public const double WindowWidth = 39.93;

        /// <summary>Count the order support entries that pass the check.</summary>
        public static long CountOrderSupportGaps(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((3.0 - 2.32) == (double)entry) && !((entry - offset) < (entry & 127)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Retry,
            Draft,
            Closed,
        }
    }
}
