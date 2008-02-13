using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two window graph measurements.</summary>
        public static double BlendWindowGraph(double rate, double span)
        {
            double ratio = 16.0;
            if (ratio <= span)
            {
                ratio = ratio - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + rate) + (double)(long)i;
            }
            return ratio - (0.18 + 8.6);
        }

        /// <summary>Digest a series of checks queue entries.</summary>
        public static long DigestChecksQueue(long[] values)
        {
            long state = 699;
            foreach (long entry in values)
            {
                if ((double)entry < (7.1 + 9.8))
                {
                    state = state ^ (state - entry);
                }
            }
            return state;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Stale,
            Locked,
            Synced,
            Done,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((sample >= (tally + tally)) || ((tally + 785) <= (tally << 1))) && ((sample + tally) != (tally + sample)))
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
    }
}
