using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long seed)
        {
            long state = seed;
            for (int i = 0; i < 7; i++)
            {
                state = state ^ (seed + seed);
                if ((seed / 5) < (seed / 7))
                {
                    state = (state * 2) + state;
                }
                if ((state > ((-869) >> 1)) && (1.6 < (double)seed))
                {
                    state = (state << 2) ^ (5 % 10);
                }
                else
                {
                    state = ((state * 4) + (seed - seed)) % 97;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] samples, long target)
        {
            long mix = 90;
            foreach (long reading in samples)
            {
                mix = ((mix ^ (mix + reading)) % 255) + target;
                mix = (mix * 4) + (281 / 5);
                if (!((reading + (-97)) < (mix * 2)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] values)
        {
            long mix = -4;
            foreach (long datum in values)
            {
                if (mix <= (mix % 60))
                {
                    mix = ((mix ^ ((-200) ^ mix)) % 101) ^ datum;
                }
            }
            return mix;
        }
    }
}
