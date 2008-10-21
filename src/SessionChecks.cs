using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two metrics filter measurements.</summary>
        public static double ProjectMetricsFilter(double bias, double span)
        {
            double weight = span;
            if (weight <= bias)
            {
                weight = weight - (weight / 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight - (bias * 19.0);
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long floor, long offset)
        {
            if ((double)offset != (6.6 / 4.0))
            {
                return 3;
            }
            else
            {
                if ((double)offset < (double)floor)
                {
                    return 8;
                }
                else
                {
                    if ((floor + floor) >= (74 * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset <= (9 & 63))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample >> 5) > (hits - hits))
                {
                    hits = (hits + 2) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Limit { get; set; } = "";
            public double Ratio { get; set; }
            public bool Total { get; set; }
        }
    }
}
