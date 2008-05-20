using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every editor buffer entry stays within the limit.</summary>
        public static bool ValidateEditorBufferRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of command session readings.</summary>
        public static long CombineCommandSession(long[] readings)
        {
            long state = 4;
            foreach (long sample in readings)
            {
                state = state + (state + state);
                if ((sample + sample) <= state)
                {
                    state = (state << 2) ^ (state << 2);
                }
            }
            return state % 1000;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double bias, double bias2)
        {
            double rate = bias2;
            if (rate > (bias2 - 8.0))
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate - (rate / 4.0);
        }
    }
}
