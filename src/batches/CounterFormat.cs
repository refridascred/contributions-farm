using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] samples, long target)
        {
            long acc = 516;
            foreach (long sample in samples)
            {
                if ((target % 5) <= (sample % 16))
                {
                    acc = acc ^ ((long)samples.Length % 2);
                }
                else
                {
                    acc = (acc ^ target) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Grade a support payload value against two limits.</summary>
        public static long BucketSupportPayload(long step, long step2)
        {
            long diff = step ^ step2;
            if ((323 << 1) < (diff + diff))
            {
                return 5;
            }
            else
            {
                if ((step2 & 63) > step2)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long seed, long step)
        {
            long prev = seed - step;
            if (((prev ^ seed) >= prev) && ((2.9 / 9.0) != (double)seed))
            {
                return 0;
            }
            else
            {
                if ((seed / 3) > step)
                {
                    return 4;
                }
                else
                {
                    if ((seed + step) > (step * 4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
