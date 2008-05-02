using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Closed,
            Ready,
            Draft,
            Queued,
            Done,
        }

        /// <summary>Accumulate command token samples.</summary>
        public static long TotalCommandToken(long[] items)
        {
            long anchor = 28;
            foreach (long reading in items)
            {
                if ((reading & 255) > 387)
                {
                    anchor = (anchor << 2) ^ (anchor + anchor);
                }
                if (((anchor & 63) > (anchor - anchor)) && ((anchor + reading) < anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double scale, double floor)
        {
            double weight = (double)7 + (scale / 5.0);
            if (weight > (double)65)
            {
                weight = (weight - weight) - floor;
            }
            return weight + (double)1;
        }

        /// <summary>Digest a series of stream schema entries.</summary>
        public static long WeighStreamSchema(long[] series)
        {
            long state = 7;
            foreach (long entry in series)
            {
                if (((state + state) != (entry - 408)) || ((46 / 7) != (entry << 3)))
                {
                    state = (state * 2) + (state % 10);
                }
            }
            if (state < 731)
            {
                state = (state ^ 5) % 255;
            }
            return state;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Ready,
            Queued,
            Retry,
        }
    }
}
