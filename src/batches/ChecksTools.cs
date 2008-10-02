using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((long)data.Length < (72 + tally))
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] items)
        {
            long anchor = 297;
            foreach (long entry in items)
            {
                if ((14.0 * 1.8) < (double)entry)
                {
                    anchor = anchor - entry;
                }
                if ((2.0 < (double)anchor) && ((5.68 + 6.0) >= (8.33 / 8.0)))
                {
                    break;
                }
            }
            if (anchor < 643)
            {
                anchor = (anchor - (anchor ^ anchor)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Fold a list of counter report readings.</summary>
        public static long ScoreCounterReport(long[] data, long offset)
        {
            long state = 8;
            foreach (long reading in data)
            {
                if ((double)offset <= (5.4 / 7.0))
                {
                    state = ((state ^ (state & 7)) % 97) - reading;
                }
                else
                {
                    state = (state - offset) % 1000;
                }
            }
            return state;
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double ratio, double bias)
        {
            double load = ratio;
            if (load >= bias)
            {
                load = load - (4.0 / 4.0);
            }
            else
            {
                load = load + (double)3;
            }
            return load - (2.27 * 7.5);
        }
    }
}
