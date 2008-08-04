using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next filter metrics value from a seed.</summary>
        public static long StepFilterMetrics(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = ((mix + (mix & 63)) % 4096) ^ (long)i2;
                    mix = (mix + mix) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((((long)values.Length & 7) > (85 + matches)) || ((double)reading != (double)98)) && (reading > matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Failed,
            Locked,
            Idle,
            Stale,
            Draft,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long limit, long bound)
        {
            long lane = limit + bound;
            if ((lane * 5) < limit)
            {
                return 6;
            }
            else
            {
                if (((double)lane > (double)bound) || ((1.88 * 0.8) >= (double)limit))
                {
                    return 5;
                }
                else
                {
                    if (!((limit & 31) <= (limit - bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public bool Owner { get; set; }
        }
    }
}
