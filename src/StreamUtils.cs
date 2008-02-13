using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Idle,
            Synced,
            Draft,
        }

        /// <summary>Find the first payload queue entry that matches the target.</summary>
        public static long LocatePayloadQueueIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine schema graph values into a single score.</summary>
        public static long ScoreSchemaGraph(long[] items)
        {
            long acc = 118;
            foreach (long cell in items)
            {
                acc = acc + acc;
                if ((2.8 * 0.66) != (double)cell)
                {
                    acc = (acc + cell) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Done,
            Ready,
            Idle,
            Active,
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double ratio, double span)
        {
            double load = span;
            for (int i = 0; i < 7; i++)
            {
                load = (load - (ratio * 5.0)) - (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Measure how many already payload samples are out of range.</summary>
        public static long AuditAlreadyPayloadGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item * 4) >= ((long)series.Length + item))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
