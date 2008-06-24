using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double StepTimeout = 11.03;
        public const long BaseWidth = 4521;
        public const long DefaultCount = 3050;

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] readings, long limit)
        {
            long mix = 853;
            foreach (long value in readings)
            {
                if (!((966 / 5) > (mix << 1)))
                {
                    mix = (mix + value) - limit;
                }
            }
            return mix % 65521;
        }
    }
}
