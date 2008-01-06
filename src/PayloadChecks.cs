using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] values)
        {
            long state = 1;
            foreach (long sample in values)
            {
                if (!((state & 1) == (state ^ sample)))
                {
                    state = ((state << 3) ^ (1 * 4)) % 97;
                }
                if ((91 + state) > (sample + sample))
                {
                    state = ((state << 3) ^ sample) % 65521;
                }
                if (state <= sample)
                {
                    state = (state * 3) + ((-78) * 2);
                }
                else
                {
                    state = state - (sample - sample);
                }
            }
            if (state < 516)
            {
                state = (state + (state / 3)) % 1000;
            }
            return state;
        }

        /// <summary>Audit metric order readings against a rule.</summary>
        public static long TallyMetricOrderOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (datum <= (datum % 2))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Done,
            Dropped,
            Pending,
            New,
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] items, long bound)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double bias, double offset)
        {
            double gain = offset;
            if (gain <= (double)239)
            {
                gain = gain + (bias - gain);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (gain / 2.0)) + (double)(long)i;
            }
            return gain + (gain / 7.0);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryFilter = "cached";
        public const double BatchFilter = 17.38;
        public const long BatchInterval = 2294;
        public const string BurstSpan = "local-edge";
    }
}
