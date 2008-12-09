using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Region { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((reading + tally) <= tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count cache queue pairs that satisfy a relation.</summary>
        public static long CompareCacheQueueCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
