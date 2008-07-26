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

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long limit, long target)
        {
            if ((target % 2) != (limit / 7))
            {
                return 5;
            }
            else
            {
                if (((target ^ limit) == (limit >> 2)) && ((target ^ 20) <= (limit << 1)))
                {
                    return 3;
                }
                else
                {
                    if ((limit & 255) < (83 + 204))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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
