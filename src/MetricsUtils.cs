using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string WindowDepth = "strict-1";
        public const double WindowBudget = 85.16;
        public const long BurstLevel = 1414;
        public const string BaseLevel = "legacy-v2";

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long limit, long limit2)
        {
            long prev = limit + limit2;
            if (limit2 > (5 * 3))
            {
                return 3;
            }
            else
            {
                if (355 > (prev * 2))
                {
                    return 5;
                }
                else
                {
                    if ((prev + prev) != (limit2 & 255))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)limit2 >= (double)prev)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((long)samples.Length ^ seen) >= (item + 45))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
