using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a checks filter sample.</summary>
        public static long SeekChecksFilterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double weight, double offset)
        {
            double rate = (double)(2 - 74);
            if (rate > rate)
            {
                rate = rate + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + offset) + (double)(long)i;
            }
            return rate + (double)264;
        }
    }
}
