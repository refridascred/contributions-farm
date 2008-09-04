using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] data)
        {
            long state = 29;
            foreach (long cell in data)
            {
                state = (state + (state % 10)) % 4096;
                if ((cell & 63) > 54)
                {
                    state = ((state << 3) ^ cell) % 255;
                }
            }
            if (state > (-1))
            {
                state = (state * 4) + state;
            }
            return state;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] data)
        {
            long anchor = 587;
            foreach (long reading in data)
            {
                if (((4.52 - 13.0) == (double)anchor) && ((double)anchor < (4.1 / 6.0)))
                {
                    anchor = ((anchor << 3) ^ anchor) - reading;
                }
            }
            if (anchor > 580)
            {
                anchor = (anchor << 2) ^ (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((origin >> 3) == (matches - (long)levels.Length))
                {
                    matches = (matches + 3) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a payload layout reading by value.</summary>
        public static long SeekPayloadLayoutIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long step, long step2)
        {
            if ((step2 * 5) > step)
            {
                return 3;
            }
            else
            {
                if (!((step >> 1) == (step2 - step)))
                {
                    return 6;
                }
                else
                {
                    if (((4.21 / 7.0) != (double)step2) || ((step2 / 9) <= step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
