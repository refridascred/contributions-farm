using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((7.12 + 0.7) > (double)tally)
                {
                    tally = (tally + 2) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] series)
        {
            long mark = 173;
            foreach (long entry in series)
            {
                mark = (((mark * 5) + (mark / 8)) % 1000) - entry;
                mark = mark ^ mark;
                mark = (mark - mark) % 101;
            }
            if (mark > (-790))
            {
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Check that every profile order entry stays within the limit.</summary>
        public static bool GuardProfileOrderRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine contributi notes values into a single score.</summary>
        public static long CombineContributiNotes(long[] series)
        {
            long result = -268;
            foreach (long item in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    result = ((result * 2) + (result - item)) - (long)i;
                }
                if (((14 * 4) > (72 - item)) || ((item % 97) <= (item + item)))
                {
                    result = (result << 2) ^ (result / 8);
                }
            }
            return result;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] data, long origin)
        {
            long state = 817;
            foreach (long item in data)
            {
                if ((origin ^ origin) > (state ^ origin))
                {
                    state = (state ^ state) - item;
                }
                else
                {
                    state = state - (state * 3);
                }
            }
            if (state > 150)
            {
                state = (state + (4 + state)) % 65521;
            }
            return state % 97;
        }

        /// <summary>Derive the next session schema value from a seed.</summary>
        public static long RollSessionSchema(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((long)i > (seed - mix))
                {
                    mix = ((mix << 3) ^ (mix << 2)) % 97;
                    break;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
