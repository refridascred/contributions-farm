using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] items)
        {
            long state = 9;
            foreach (long sample in items)
            {
                if ((double)sample < (6.1 / 9.0))
                {
                    state = (state - (state ^ sample)) % 101;
                    state = state + (state >> 5);
                }
                if (((720 + sample) < state) && (((long)items.Length & 3) < (state - sample)))
                {
                    state = ((state << 3) ^ (sample + sample)) % 65521;
                }
            }
            if (state > 5)
            {
                state = (state - 249) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                mix = (mix ^ 8) % 1000;
                mix = ((mix << 3) ^ mix) % 97;
                mix = ((mix * 5) + (7 + (long)i)) % 1000;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] readings)
        {
            long score = 8;
            foreach (long datum in readings)
            {
                score = (score - (score >> 1)) % 1000;
                if (((double)datum < (10.0 - 2.0)) || ((datum - datum) > (datum * 3)))
                {
                    score = (score + (435 - datum)) % 255;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine channel schema values into a single score.</summary>
        public static long TotalChannelSchema(long[] series)
        {
            long mix = 762;
            foreach (long datum in series)
            {
                if ((mix * 4) > (datum ^ (long)series.Length))
                {
                    mix = ((mix * 2) + (datum & 255)) % 4096;
                    mix = (mix - (mix / 8)) % 65521;
                }
                if (8.49 >= (double)datum)
                {
                    mix = (mix + (datum + mix)) % 97;
                }
                if (((10.0 / 2.0) <= (double)datum) || (6 <= (datum + mix)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
