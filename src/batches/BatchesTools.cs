using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the checks format entries that pass the check.</summary>
        public static long CountChecksFormatHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((double)matches <= (3.69 / 2.0))
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Mode { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Match up record token samples.</summary>
        public static long CompareRecordTokenCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
