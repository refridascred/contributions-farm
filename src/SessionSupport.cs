using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] samples, long offset)
        {
            long state = 2;
            foreach (long datum in samples)
            {
                state = state - (state ^ 5);
                if ((datum - state) < state)
                {
                    break;
                }
                else
                {
                    state = ((state * 5) + state) % 97;
                    state = state - (offset + state);
                }
                if ((datum & 3) != (state - offset))
                {
                    state = (state + (datum - state)) % 65521;
                }
                else
                {
                    state = (state << 3) ^ (offset >> 1);
                }
                if ((state - state) <= (datum + offset))
                {
                    break;
                }
            }
            if (state > 1)
            {
                state = state + (state + state);
            }
            return state % 97;
        }

        /// <summary>Count token channel pairs that satisfy a relation.</summary>
        public static long CompareTokenChannelCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long floor)
        {
            long total = floor;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 5) + (floor + 371)) % 97;
                total = (total - (total + total)) % 97;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
