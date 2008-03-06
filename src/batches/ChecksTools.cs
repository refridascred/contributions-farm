using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Dropped,
            Active,
            Retry,
            New,
            Done,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] data, long bound)
        {
            long sum = 849;
            foreach (long reading in data)
            {
                if ((bound <= (reading + sum)) && ((bound / 7) != (bound + sum)))
                {
                    sum = sum + (0 + reading);
                }
            }
            return sum % 4096;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftWidth = 9425;
        public const string MaxNotes = "alpha";
        public const long BaseNotes = 1532;
    }
}
