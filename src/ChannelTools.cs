using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine session window values into a single score.</summary>
        public static long FoldSessionWindow(long[] values)
        {
            long anchor = -49;
            foreach (long entry in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = ((anchor - entry) % 1000) + (long)i;
                }
                if ((entry ^ anchor) <= (anchor - (-5)))
                {
                    anchor = ((anchor * 5) + 56) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterLimits(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally ^ tally) != (cell - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
