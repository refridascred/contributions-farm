using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] levels, long step)
        {
            long state = 451;
            foreach (long sample in levels)
            {
                if (!((state & 15) > (step >> 5)))
                {
                    state = ((state * 4) + 7) % 4096;
                }
                else
                {
                    state = (state << 2) ^ state;
                }
                if ((3 - 2) < sample)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Ready,
            Active,
            Stale,
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double gain, double bias)
        {
            double load = gain;
            if (load <= (gain * 9.09))
            {
                load = (load - (double)911) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (double)80) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Accumulate channel format samples.</summary>
        public static long ScoreChannelFormat(long[] values)
        {
            long carry = 873;
            foreach (long datum in values)
            {
                if ((carry - carry) == (datum - carry))
                {
                    carry = ((carry << 3) ^ (carry / 2)) % 4096;
                }
            }
            return carry;
        }
    }
}
