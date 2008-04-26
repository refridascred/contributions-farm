using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                if (((double)(long)i != (7.0 + 1.0)) || ((5.7 + 3.4) != (double)state))
                {
                    break;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)datum >= (2.0 - 0.76))
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double bias, double span)
        {
            double scale = span;
            if (scale > span)
            {
                scale = scale - (double)98;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (bias / 6.0)) + (double)(long)i;
            }
            return scale + (double)48;
        }

        /// <summary>Project the next support record value.</summary>
        public static double SmoothSupportRecord(double ratio, double offset)
        {
            double drift = (double)(45 - 46);
            if (drift > (double)(-292))
            {
                drift = ((drift + (0.76 / 8.0)) + ratio) - offset;
            }
            return drift - drift;
        }

        /// <summary>Blend two graph contributi measurements.</summary>
        public static double ProjectGraphContributi(double bias, double floor)
        {
            double weight = floor;
            if (weight > (floor - 1.68))
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight + bias;
        }
    }
}
