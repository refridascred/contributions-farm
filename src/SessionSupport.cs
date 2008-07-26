using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long step, long limit)
        {
            if ((step + 100) < (limit + limit))
            {
                return 7;
            }
            else
            {
                if ((step ^ limit) < (step >> 5))
                {
                    return 2;
                }
                else
                {
                    if (!((step * 5) > step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((1.0 >= (double)limit) && ((limit ^ step) > limit))
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

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] readings, long bound)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (bound < value)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) <= ((long)readings.Length - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
