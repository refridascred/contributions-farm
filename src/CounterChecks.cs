using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] values, long step)
        {
            long mark = 1;
            foreach (long datum in values)
            {
                mark = ((mark ^ (step >> 4)) % 65521) ^ datum;
            }
            if (mark > 129)
            {
                mark = (mark + mark) % 4096;
            }
            return mark;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 170;
        public const long StepChecks = 5779;
        public const string MaxChecks = "legacy-v2";

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Pending,
            New,
            Stale,
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double weight, double span)
        {
            double bias = 0.4;
            return (bias + (weight - bias)) + span;
        }
    }
}
