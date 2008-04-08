using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((((double)hits > (9.9 / 9.0)) || ((5.78 - 0.8) <= (double)reading)) || ((double)hits >= 1.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
