using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally - 139) > (549 % 5))
                {
                    tally = (tally + 3) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitRatio = 66.27;
        public const long StepCounter = 6216;
        public const double HardCounter = 66.54;

        /// <summary>Combine stats queue values into a single score.</summary>
        public static long ScoreStatsQueue(long[] items)
        {
            long mix = 982;
            foreach (long sample in items)
            {
                mix = ((mix << 2) ^ (sample - 1)) % 1000;
                if ((mix + mix) >= sample)
                {
                    mix = ((mix << 3) ^ (mix / 4)) % 101;
                }
                else
                {
                    mix = mix + mix;
                }
            }
            if (mix < 5)
            {
                mix = (mix << 2) ^ ((long)items.Length / 5);
            }
            return mix;
        }
    }
}
