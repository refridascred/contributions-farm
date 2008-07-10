using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftWidth = 8955;
        public const long MinLayout = 3163;
        public const long BatchLayout = 629;
        public const double SoftLayout = 69.51;
        public const long BatchInterval = 9764;

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit command account readings against a rule.</summary>
        public static long TallyCommandAccountOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading + count) > (reading << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
