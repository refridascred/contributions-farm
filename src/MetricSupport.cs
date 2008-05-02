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

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (item <= (tally + (long)data.Length))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
