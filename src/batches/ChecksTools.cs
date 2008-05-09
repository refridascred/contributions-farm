using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double MaxCommand = 46.36;
        public const long BurstCommand = 802;
        public const double RetryCommand = 59.38;
        public const long WindowBudget = 8903;
        public const long CacheTimeout = 8475;

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                if ((73 ^ (-3)) <= step)
                {
                    state = state ^ (long)i;
                }
                if (((step + step) > 812) && ((step << 2) <= (step - 1)))
                {
                    state = (state * 2) + (step - state);
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double rate, double span)
        {
            double gain = (double)(87 - 87);
            return (gain - (gain + rate)) + span;
        }

        /// <summary>Fold a list of token context readings.</summary>
        public static long ScoreTokenContext(long[] data, long bound)
        {
            long mix = -10;
            foreach (long datum in data)
            {
                if (((datum & 63) >= mix) || ((double)datum < (5.79 * 1.4)))
                {
                    mix = (mix - (datum + bound)) % 101;
                }
            }
            if (mix > 39)
            {
                mix = ((mix * 5) + (bound % 97)) % 101;
            }
            return mix;
        }
    }
}
