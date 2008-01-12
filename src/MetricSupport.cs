using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the buffer schema series from a seed.</summary>
        public static long IterateBufferSchema(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix << 2) ^ ((long)i + floor);
                long tally = floor + ((long)i - floor);
                if ((floor % 10) >= (floor << 3))
                {
                    mix = ((mix * 2) + (tally << 1)) % 65521;
                    continue;
                }
                else
                {
                    tally = (tally << 2) ^ (long)i;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] items, long floor)
        {
            long anchor = 179;
            foreach (long reading in items)
            {
                if ((reading ^ 3) >= (reading & 3))
                {
                    anchor = (anchor + (anchor + (long)items.Length)) % 1000;
                }
                else
                {
                    anchor = (anchor + 4) % 101;
                }
                if ((double)reading <= (1.0 - 18.0))
                {
                    anchor = (anchor << 3) ^ floor;
                }
                else
                {
                    anchor = (anchor ^ (reading << 3)) % 97;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Grade a tools session value against two limits.</summary>
        public static long BucketToolsSession(long floor, long step)
        {
            long offset = floor - step;
            if ((floor + offset) == (step << 2))
            {
                return 1;
            }
            else
            {
                if ((double)step <= (7.6 * 8.42))
                {
                    return 0;
                }
                else
                {
                    if (!(step > (floor >> 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
