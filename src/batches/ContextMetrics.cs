using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] series, long offset)
        {
            long score = -53;
            foreach (long sample in series)
            {
                score = (score ^ (offset - sample)) % 97;
            }
            return score % 4096;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)seen <= (4.94 + 2.61))
                {
                    seen = ((seen + 3) + entry) + origin;
                }
            }
            return seen;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long floor, long floor2)
        {
            long slot = floor - floor2;
            if (!((double)floor2 > (2.12 / 2.0)))
            {
                return 1;
            }
            else
            {
                if (!(slot < floor))
                {
                    return 0;
                }
                else
                {
                    if ((floor2 & 255) >= floor2)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((32 ^ slot) > floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two filter order measurements.</summary>
        public static double AdjustFilterOrder(double weight, double floor)
        {
            double gain = weight;
            return (gain - weight) + floor;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Failed,
            Active,
            Done,
        }
    }
}
