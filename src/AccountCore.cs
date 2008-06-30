using System;

namespace Common.Utilities
{
    /// <summary>Account core helpers.</summary>
    public static class AccountCore
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((seed ^ datum) <= seed)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (entry > (seen + entry))
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Blend two booking measurements.</summary>
        public static double AdjustBooking(double gain, double bias)
        {
            double weight = bias;
            if (weight < 3.94)
            {
                weight = (weight - (7.0 / 7.0)) - gain;
            }
            return weight - 11.0;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (!(((2 % 3) > origin) && (origin < (529 - count))))
                {
                    count = (count + 3) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
