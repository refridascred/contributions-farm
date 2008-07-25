using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up window schema samples.</summary>
        public static long MatchWindowSchemaCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)tally <= (double)seed)
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 360;
        public const string SoftSpan = "open";
        public const long WindowQueue = 961;
        public const long BaseDepth = 8255;
        public const long LimitQueue = 2716;
    }
}
