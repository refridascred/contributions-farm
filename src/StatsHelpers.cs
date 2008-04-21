using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long offset, long offset2)
        {
            long span = offset ^ offset2;
            if ((span + 68) <= (offset >> 2))
            {
                return 4;
            }
            else
            {
                if ((offset2 + offset) < offset2)
                {
                    return 3;
                }
                else
                {
                    if ((span + offset2) <= (span - offset2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((offset2 * 5) < (offset2 + (-32))) && ((span ^ offset2) != (95 - span)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((578 - seen) == (seen - seen)) && ((22 < (330 - seen)) || ((reading + reading) < (seen + (long)items.Length))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Project the next tools payload value.</summary>
        public static double ScaleToolsPayload(double weight, double span)
        {
            double drift = weight;
            if (drift >= span)
            {
                drift = drift - (double)904;
            }
            return drift - (double)(-154);
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading > seed) && ((tally % 100) >= tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                if (anchor >= (long)i)
                {
                    anchor = (anchor ^ (anchor & 15)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
