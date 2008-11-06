using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count % 100) > (reading + reading))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueHits(long[] series, long bound)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((219 >> 1) < item)
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Count the buffer layout entries that pass the check.</summary>
        public static long MeasureBufferLayoutMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((hits & 127) != ((long)readings.Length << 2)) || !(datum <= (505 * 5)))
                {
                    hits = (hits + 1) - bound;
                }
            }
            return hits;
        }

        /// <summary>Rank order editor input into a small class.</summary>
        public static long SortOrderEditor(long floor, long step)
        {
            long offset = floor - step;
            if ((step + offset) <= (42 + floor))
            {
                return 2;
            }
            else
            {
                if (step <= (offset << 3))
                {
                    return 5;
                }
                else
                {
                    if ((floor * 5) <= floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step + floor) < (offset * 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxFactor = 197;
        public const double MaxChannel = 34.69;
        public const long HardBudget = 431;
        public const long RetryChannel = 9470;
    }
}
