using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a stream report reading.</summary>
        public static double SmoothStreamReport(double ratio, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + scale) - (double)(long)i;
            }
            return scale - (ratio / 6.0);
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Draft,
            Dropped,
            Done,
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
