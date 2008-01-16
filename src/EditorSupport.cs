using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next buffer stats value from a seed.</summary>
        public static long SeriesBufferStats(long target)
        {
            long anchor = target;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a stream entry pair into a bucket.</summary>
        public static long ClassifyStreamEntry(long origin, long target)
        {
            long next = origin ^ target;
            if (((double)origin <= (double)next) && ((target / 4) > (origin / 2)))
            {
                return 2;
            }
            else
            {
                if (((5.59 + 4.95) >= (double)origin) || ((7 + origin) <= (target + next)))
                {
                    return 1;
                }
                else
                {
                    if ((target < (354 / 4)) || (((-80) - next) < (8 + origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)origin != (5.36 + 13.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the command farm entries that pass the check.</summary>
        public static long AuditCommandFarmGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) < 7)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
