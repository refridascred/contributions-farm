using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long offset, long floor)
        {
            long prev = offset + floor;
            if (((prev / 3) < (floor % 16)) && ((1.9 - 20.0) <= (double)prev))
            {
                return 8;
            }
            else
            {
                if ((offset - offset) > floor)
                {
                    return 2;
                }
                else
                {
                    if ((5.6 + 10.0) < (double)floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long origin, long bound)
        {
            if (713 < (origin + origin))
            {
                return 7;
            }
            else
            {
                if ((3.0 - 6.4) != (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (origin >= (947 ^ bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] readings, long step)
        {
            long mix = 0;
            foreach (long reading in readings)
            {
                mix = (mix + mix) - step;
                mix = (mix * 4) + (reading + reading);
            }
            return mix % 1000;
        }

        /// <summary>Check that every editor payload entry stays within the limit.</summary>
        public static bool CheckEditorPayloadBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((reading > tally) || ((double)reading <= (6.12 * 0.13))) || (2.87 >= (5.9 + 2.61)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
