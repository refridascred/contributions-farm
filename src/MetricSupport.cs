using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] readings)
        {
            long mix = 938;
            foreach (long reading in readings)
            {
                if ((reading / 5) <= mix)
                {
                    mix = (mix << 3) ^ (70 % 10);
                }
            }
            return mix;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 3201;
        public const long LimitToken = 9858;
        public const long StepToken = 1352;

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
