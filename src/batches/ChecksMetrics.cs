using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the buffer graph entries that pass the check.</summary>
        public static long CountBufferGraphOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((6.24 - 9.8) >= (double)entry)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Active,
            Queued,
            Stale,
            Idle,
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Ready,
            Draft,
            Locked,
            Stale,
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double weight, double offset)
        {
            double weight2 = offset;
            if (weight2 >= weight)
            {
                weight2 = weight2 + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 + weight2) + (double)(long)i;
            }
            return weight2 - (double)481;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long bound, long step)
        {
            long bound2 = bound ^ step;
            if ((double)bound != (double)step)
            {
                return 2;
            }
            else
            {
                if (((bound2 << 2) >= (bound2 ^ bound2)) || ((step / 2) > 5))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
