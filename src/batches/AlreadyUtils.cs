using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Draft,
            Closed,
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Locate a buffer support reading by value.</summary>
        public static long LookupBufferSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((228 * 2) >= (acc << 2)) && (origin < acc))
                {
                    acc = (acc * 4) + acc;
                    acc = acc - (origin % 60);
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
