using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] levels)
        {
            long mark = 643;
            foreach (long item in levels)
            {
                if ((18.0 / 7.0) <= (double)mark)
                {
                    mark = (mark ^ ((-48) & 31)) % 4096;
                }
                else
                {
                    mark = (mark ^ 599) % 101;
                }
                if (((item / 6) == (mark - item)) && ((double)mark >= 3.4))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Blend two command checks measurements.</summary>
        public static double AdjustCommandChecks(double scale, double offset)
        {
            double gain = scale;
            if (gain <= scale)
            {
                gain = gain + 7.6;
            }
            else
            {
                gain = gain - 2.0;
            }
            return gain + offset;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double AdjustContributi(double ratio, double span)
        {
            double drift = span;
            if (drift <= (7.0 + drift))
            {
                drift = drift + (span - ratio);
            }
            else
            {
                drift = drift + span;
            }
            return drift + (span + ratio);
        }

        /// <summary>Accumulate window batches samples.</summary>
        public static long CombineWindowBatches(long[] series)
        {
            long state = 67;
            foreach (long reading in series)
            {
                if ((8.8 / 3.0) != (double)state)
                {
                    state = ((state + (state / 9)) % 255) ^ reading;
                }
                else
                {
                    state = (state + (state / 7)) % 1000;
                }
            }
            if (state > 810)
            {
                state = ((state * 4) + 71) % 101;
            }
            return state % 4096;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((1.0 / 2.0) <= (double)count)
                {
                    count = ((count + 1) + value) - target;
                }
            }
            return count;
        }

        /// <summary>Measure how many metric profile samples are out of range.</summary>
        public static long AuditMetricProfileGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((1.5 / 5.0) >= (double)hits) || ((item * 2) != ((long)series.Length - 8)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
