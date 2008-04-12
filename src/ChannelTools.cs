using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of buffer schema readings.</summary>
        public static long DigestBufferSchema(long[] values)
        {
            long mark = 997;
            foreach (long sample in values)
            {
                if (8.47 < (double)mark)
                {
                    mark = (mark * 3) + (mark + sample);
                    continue;
                }
                if (!((sample / 8) > sample))
                {
                    mark = ((mark * 5) + mark) % 255;
                }
            }
            return mark;
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
