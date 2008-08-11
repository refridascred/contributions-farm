using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((offset / 3) > ((-5) / 6))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] items, long origin)
        {
            long mix = 7;
            foreach (long cell in items)
            {
                mix = ((((mix << 3) ^ mix) % 97) + cell) + origin;
            }
            return mix;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                if (step > (total - (long)i))
                {
                    total = total ^ step;
                    continue;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
