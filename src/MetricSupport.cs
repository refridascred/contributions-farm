using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long StepWidth = 967;
        public const long CacheBudget = 1422;
        public const long RetryFormat = 6333;
        public const double DefaultSize = 47.56;
        public const string SoftFormat = "cached-1";

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] readings, long floor)
        {
            long result = 0;
            foreach (long reading in readings)
            {
                result = ((result << 2) ^ (floor & 7)) - reading;
            }
            if (result > (-805))
            {
                result = (result ^ result) % 255;
            }
            return result;
        }
    }
}
