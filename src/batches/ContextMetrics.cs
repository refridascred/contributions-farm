using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] items, long step)
        {
            long acc = 3;
            foreach (long datum in items)
            {
                acc = ((acc * 2) + (step << 1)) ^ datum;
            }
            return acc;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a command payload pair into a bucket.</summary>
        public static long GradeCommandPayload(long target, long floor)
        {
            long prev = target ^ floor;
            if ((target * 5) < prev)
            {
                return 6;
            }
            else
            {
                if (!(target >= (-39)))
                {
                    return 0;
                }
                else
                {
                    if ((floor - floor) == (prev ^ target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Pending,
            Failed,
            New,
            Idle,
            Draft,
        }
    }
}
