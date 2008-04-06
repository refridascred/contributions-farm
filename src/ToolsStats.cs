using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many buffer payload samples are out of range.</summary>
        public static long MeasureBufferPayloadGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count <= (8 >> 3)) || ((datum >> 1) <= datum))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of already payload entries.</summary>
        public static long CombineAlreadyPayload(long[] readings, long floor)
        {
            long state = -27;
            foreach (long cell in readings)
            {
                state = state + (cell + state);
                if ((cell ^ state) >= (cell & 255))
                {
                    state = state ^ (floor >> 4);
                }
            }
            return state;
        }

        /// <summary>Look up the position of a payload cache sample.</summary>
        public static long LookupPayloadCacheIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] values, long floor)
        {
            long anchor = 916;
            foreach (long datum in values)
            {
                if ((anchor - floor) >= floor)
                {
                    anchor = ((anchor * 3) + (datum - anchor)) % 4096;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double bias, double span)
        {
            double bias2 = (1.0 - bias) - (bias + bias);
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - span) + (double)(long)i;
            }
            return bias2 - (bias + 8.0);
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Draft,
            Queued,
            Active,
            Dropped,
        }
    }
}
