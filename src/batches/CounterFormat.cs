using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((seed >> 5) > 695)
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Count the editor session entries that pass the check.</summary>
        public static long TallyEditorSessionGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item >> 1) > (49 + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a payload record pair into a bucket.</summary>
        public static long BucketPayloadRecord(long seed, long origin)
        {
            if ((origin / 5) <= (seed + origin))
            {
                return 4;
            }
            else
            {
                if ((origin << 3) > seed)
                {
                    return 8;
                }
                else
                {
                    if ((1.1 - 0.1) <= (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((4.17 + 6.0) > (double)origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
