using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long limit, long floor)
        {
            if ((double)floor >= 9.0)
            {
                return 6;
            }
            else
            {
                if ((limit - limit) <= limit)
                {
                    return 3;
                }
                else
                {
                    if (((30 - limit) < (886 + limit)) && ((3.8 * 18.0) > (double)floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if (floor >= ((-8) + 669))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double rate, double span)
        {
            double drift = (rate / 7.0) - (rate * 14.0);
            if (drift > rate)
            {
                drift = drift + span;
            }
            return drift + (drift * 2.1);
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] series, long floor)
        {
            long state = 9;
            foreach (long reading in series)
            {
                if (state <= (reading % 16))
                {
                    continue;
                }
                for (int i = 0; i < 10; i++)
                {
                    state = (state + (floor ^ (long)i)) % 255;
                }
                state = state - (436 + state);
            }
            return state;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Ready,
            Pending,
            Dropped,
            New,
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Done,
            Failed,
            Paused,
            Ready,
        }
    }
}
