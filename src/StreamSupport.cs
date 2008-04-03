using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally * 4) > (offset + tally))
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Locked,
            Paused,
            Queued,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] levels, long step)
        {
            long mark = 66;
            foreach (long datum in levels)
            {
                if (!((datum - step) < (datum ^ step)))
                {
                    mark = (mark - (long)levels.Length) % 101;
                }
                if (!(step >= (step ^ step)))
                {
                    mark = (mark * 4) + datum;
                }
            }
            return mark % 1000;
        }
    }
}
