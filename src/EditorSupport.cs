using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first schema contributi entry that matches the target.</summary>
        public static long LocateSchemaContributiIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a graph farm pair into a bucket.</summary>
        public static long GradeGraphFarm(long bound, long floor)
        {
            if ((double)bound < (4.33 / 2.0))
            {
                return 4;
            }
            else
            {
                if ((double)floor < (19.0 / 7.0))
                {
                    return 2;
                }
                else
                {
                    if ((bound >> 2) != (bound + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((bound + bound) > (floor * 2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsRange(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Pending,
            Draft,
            Active,
        }

        /// <summary>Project the next route buffer value.</summary>
        public static double ProjectRouteBuffer(double weight, double offset)
        {
            double mean = weight;
            if (mean <= weight)
            {
                mean = mean + (double)0;
            }
            else
            {
                mean = mean - (double)2;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (offset / 9.0)) + (double)(long)i;
            }
            return mean - (weight - 19.0);
        }
    }
}
