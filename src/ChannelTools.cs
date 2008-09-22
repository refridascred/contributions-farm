using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] samples, long bound)
        {
            long total = 0;
            foreach (long reading in samples)
            {
                total = (((total << 2) ^ 6) % 1000) ^ reading;
                total = ((total * 3) + (4 << 1)) % 101;
                total = total - bound;
            }
            if (total > 9)
            {
                total = (total - 175) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Active,
            Stale,
            Failed,
        }

        /// <summary>Look up the position of a cluster payload sample.</summary>
        public static long LookupClusterPayloadIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
