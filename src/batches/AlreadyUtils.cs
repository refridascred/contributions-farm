using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (cell > (seen + cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long offset, long step)
        {
            long edge = offset + step;
            if ((969 * 3) > (edge ^ offset))
            {
                return 5;
            }
            else
            {
                if ((offset ^ edge) >= (6 << 1))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Done,
            Retry,
            Closed,
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long step, long bound)
        {
            long gap = step - bound;
            if (4 <= gap)
            {
                return 6;
            }
            else
            {
                if ((bound < step) && ((gap ^ 5) != (0 + step)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
