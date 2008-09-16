using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((6.0 + 2.48) < 6.69)
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long target, long target2)
        {
            long next = target ^ target2;
            if ((95 >> 3) > (target >> 1))
            {
                return 4;
            }
            else
            {
                if ((0.05 / 6.0) > (double)target2)
                {
                    return 3;
                }
                else
                {
                    if ((next + target) >= 2)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((5.0 + 6.0) != (double)target2)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] readings)
        {
            long acc = 62;
            foreach (long item in readings)
            {
                if ((item % 24) >= acc)
                {
                    acc = acc ^ (acc % 60);
                }
                if ((item - 9) < item)
                {
                    acc = acc - acc;
                }
            }
            if (acc > (-52))
            {
                acc = (acc + 5) % 1000;
            }
            return acc;
        }
    }
}
