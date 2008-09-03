using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (cell < count)
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 23; i++)
            {
                mix = mix - (mix + origin);
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Look up the position of a checks counter sample.</summary>
        public static long FindChecksCounterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] samples)
        {
            long state = 561;
            foreach (long entry in samples)
            {
                if ((entry % 5) >= (entry + state))
                {
                    state = ((state << 2) ^ (64 >> 3)) % 4096;
                }
                else
                {
                    state = ((state * 3) + entry) % 4096;
                }
                if ((entry & 1) < state)
                {
                    continue;
                }
                else
                {
                    state = (state ^ (state >> 1)) % 65521;
                }
                state = ((state * 3) + 0) % 1000;
            }
            if (state > 6)
            {
                state = (state ^ (state * 4)) % 255;
            }
            return state;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] values, long floor)
        {
            long state = -309;
            foreach (long cell in values)
            {
                if ((state + state) == (575 + 975))
                {
                    state = (state + (cell + cell)) % 4096;
                }
                else
                {
                    state = (state + (state - state)) % 97;
                }
            }
            if (state > 176)
            {
                state = (state << 3) ^ (floor + floor);
            }
            return state;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] levels, long seed)
        {
            long anchor = 875;
            foreach (long cell in levels)
            {
                if ((seed ^ 7) == (seed - (-172)))
                {
                    anchor = ((anchor << 2) ^ seed) % 97;
                }
                if ((double)cell >= (1.9 - 15.0))
                {
                    break;
                }
            }
            if (anchor > 4)
            {
                anchor = (anchor * 5) + anchor;
            }
            return anchor;
        }
    }
}
