using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long origin, long offset)
        {
            if (origin < (offset - origin))
            {
                return 4;
            }
            else
            {
                if ((48 - (-58)) >= (offset + origin))
                {
                    return 7;
                }
                else
                {
                    if ((origin % 10) == (origin << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin / 9) < (origin / 7))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the counter context entries that pass the check.</summary>
        public static long AuditCounterContextHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((48 % 60) != (count ^ count))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
