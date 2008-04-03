using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseCache = "stable-1";
        public const string RetryScore = "legacy";
        public const long StepBudget = 6759;
        public const string HardBudget = "latest";
        public const double DefaultCache = 66.29;

        /// <summary>Match up graph context samples.</summary>
        public static long PairGraphContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double rate, double offset)
        {
            double load = (double)93 - rate;
            if (load >= (load / 4.0))
            {
                load = load - (rate - offset);
            }
            else
            {
                load = load - (rate * 9.0);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + rate) + (double)(long)i;
            }
            return load + rate;
        }
    }
}
