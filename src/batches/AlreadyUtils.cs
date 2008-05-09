using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double ratio, double offset)
        {
            double drift = (offset * 5.74) + ratio;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (drift / 8.0)) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((((double)datum == (7.2 + 2.65)) || ((58 - (long)data.Length) < (datum ^ datum))) && (hits <= datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] data)
        {
            long anchor = 8;
            foreach (long datum in data)
            {
                if ((0.24 < (3.0 * 7.6)) || (10 >= (datum << 1)))
                {
                    anchor = ((anchor << 3) ^ (datum + anchor)) % 4096;
                }
                else
                {
                    anchor = (anchor + (anchor + anchor)) % 97;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
