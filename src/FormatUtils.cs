using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double rate, double floor)
        {
            double rate2 = (double)(9 << 2);
            if (rate2 > 6.03)
            {
                rate2 = (rate2 + rate2) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 + (rate2 / 3.0)) + (double)(long)i;
            }
            return rate2 + (rate * 9.2);
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally + 8) == (tally + tally))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate filter command samples.</summary>
        public static long DigestFilterCommand(long[] levels)
        {
            long state = 868;
            foreach (long entry in levels)
            {
                long matches = (state - entry) >> 1;
                if (((-1) * 3) != (state / 5))
                {
                    matches = (matches - (381 & 15)) % 1000;
                    break;
                }
                else
                {
                    state = state ^ (entry ^ matches);
                    state = (state * 2) + (state / 2);
                }
                state = (state ^ (state - entry)) % 101;
            }
            return state;
        }

        /// <summary>Validate cluster order readings against a bound.</summary>
        public static bool GuardClusterOrderBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
