using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Total { get; set; }
            public double Size { get; set; }
            public long Label { get; set; }
        }

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
