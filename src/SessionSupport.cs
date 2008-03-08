using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] values, long step)
        {
            long state = 448;
            foreach (long sample in values)
            {
                state = (state + sample) % 65521;
            }
            if (state > 1)
            {
                state = ((state * 5) + (step - step)) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Count tools command pairs that satisfy a relation.</summary>
        public static long MatchToolsCommandCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
