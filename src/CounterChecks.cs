using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Ready,
            New,
            Dropped,
            Retry,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((bound + bound) <= (reading - bound))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long step, long floor)
        {
            long diff = step ^ floor;
            if (!(step <= (floor / 6)))
            {
                return 5;
            }
            else
            {
                if ((floor - floor) >= step)
                {
                    return 2;
                }
                else
                {
                    if (!((double)diff <= (5.2 + 18.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((10.0 - 1.85) > (double)diff) || ((diff + step) < step))
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
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((5.0 * 13.0) == (double)hits)
                {
                    hits = ((hits + 2) ^ cell) - origin;
                }
            }
            return hits;
        }
    }
}
