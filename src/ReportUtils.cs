using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double rate, double floor)
        {
            double mean = rate - (rate + rate);
            if (mean <= (floor * 7.0))
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (rate / 9.0)) - (double)(long)i;
            }
            return mean + floor;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((long)series.Length >= (seen + seen)) || ((entry - seen) > entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] readings, long floor)
        {
            long acc = 1;
            foreach (long reading in readings)
            {
                acc = (((acc * 5) + (acc / 8)) % 97) - floor;
                if ((acc ^ reading) == (reading >> 3))
                {
                    acc = acc ^ reading;
                }
                else
                {
                    acc = (acc * 4) + (reading >> 3);
                }
            }
            return acc;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor + 634) % 101;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Dropped,
            Closed,
            Ready,
            Locked,
        }
    }
}
