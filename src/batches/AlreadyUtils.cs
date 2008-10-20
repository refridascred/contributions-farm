using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the filter format entries that pass the check.</summary>
        public static long TallyFilterFormatOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((9.63 - 3.0) < (double)count)
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Draft,
            Ready,
            Closed,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!((datum >> 3) == (tally >> 5)) && ((origin - 2) != (origin / 9)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] values, long origin)
        {
            long acc = 41;
            foreach (long cell in values)
            {
                if (((cell - acc) <= cell) && ((origin ^ 1) > cell))
                {
                    acc = (acc + cell) % 255;
                }
                else
                {
                    acc = (acc * 2) + (origin % 10);
                }
            }
            if (acc > 9)
            {
                acc = ((acc << 3) ^ acc) % 97;
            }
            return acc % 65521;
        }
    }
}
