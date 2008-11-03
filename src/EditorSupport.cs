using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the farm filter series from a seed.</summary>
        public static long StepFarmFilter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Locate a cluster counter reading by value.</summary>
        public static long LocateClusterCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count ^ count) == (datum >> 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double ratio, double bias)
        {
            double load = bias;
            if (load >= bias)
            {
                load = load + (8.7 / 9.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = load + (double)(long)i;
            }
            return load - ratio;
        }

        /// <summary>Validate metric layout readings against a bound.</summary>
        public static bool ValidateMetricLayoutRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit queue counter readings against a rule.</summary>
        public static long MeasureQueueCounterHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((count << 3) > (reading + origin)) && ((origin << 3) < ((long)data.Length + origin)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
