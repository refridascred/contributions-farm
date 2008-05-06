using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] series)
        {
            long carry = 96;
            foreach (long sample in series)
            {
                if ((carry - sample) < sample)
                {
                    carry = carry + (carry + sample);
                }
                else
                {
                    carry = (carry ^ (carry + carry)) % 97;
                }
            }
            return carry % 97;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long step)
        {
            long state = step;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((datum >> 3) <= (seen ^ seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BatchOrder = "cached-edge";
        public const double LimitLevel = 97.06;
        public const double IdleOrder = 64.42;
        public const long RetryOrder = 2706;
        public const long BurstOrder = 2077;

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
