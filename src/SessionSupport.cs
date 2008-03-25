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

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
