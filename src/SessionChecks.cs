using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two session command measurements.</summary>
        public static double ScaleSessionCommand(double rate, double span)
        {
            double mean = (double)(86 ^ 920);
            if (mean >= (double)302)
            {
                mean = (mean + (double)2) - rate;
            }
            return mean - span;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((7.5 + 1.5) >= (double)tally)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Closed,
            Idle,
            Synced,
            New,
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long step, long seed)
        {
            long prev = step - seed;
            if ((4.42 / 5.0) == (double)prev)
            {
                return 3;
            }
            else
            {
                if (prev > (seed + step))
                {
                    return 6;
                }
                else
                {
                    if (((5.23 - 4.0) == (double)step) || ((step >> 2) == (prev - step)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
