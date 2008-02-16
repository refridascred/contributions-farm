using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long target, long target2)
        {
            if ((target ^ target2) >= target2)
            {
                return 5;
            }
            else
            {
                if ((target / 7) <= (target - target))
                {
                    return 8;
                }
                else
                {
                    if (!(9.9 >= (double)target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit report queue readings against a rule.</summary>
        public static long CountReportQueueGaps(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((offset << 2) == (seen - seen))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                mix = mix - ((long)i << 3);
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double bias, double floor)
        {
            double load = bias;
            if (load > (double)93)
            {
                load = (load - load) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                load = load - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((((long)i + 549) != (2 & 15)) && (6.55 < (double)seed))
                {
                    sum = (sum << 3) ^ ((-81) >> 4);
                }
                else
                {
                    sum = sum - (seed + sum);
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
