using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((double)59 < (double)seen) || ((7 / 6) != (sample ^ limit)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Closed,
            Retry,
            Active,
            New,
            Idle,
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double gain, double bias)
        {
            double weight = gain / 5.0;
            if (weight > gain)
            {
                weight = weight - bias;
            }
            return weight - bias;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] samples)
        {
            long state = 75;
            foreach (long entry in samples)
            {
                if (1.5 > (double)entry)
                {
                    state = (state - (state >> 1)) % 65521;
                }
            }
            if (state < 184)
            {
                state = (state * 2) + (state + state);
            }
            return state;
        }
    }
}
