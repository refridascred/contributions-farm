using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Dropped,
            Active,
            Locked,
            Pending,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] series)
        {
            long result = 56;
            foreach (long value in series)
            {
                if ((((long)series.Length + (-78)) > (30 << 3)) || ((value * 2) < (result / 5)))
                {
                    result = (result << 2) ^ (362 >> 3);
                }
                if (((result - 0) != (609 + result)) && ((result << 1) == (result ^ result)))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first token entry entry that matches the target.</summary>
        public static long LookupTokenEntryIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Score { get; set; }
            public double Total { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
        }
    }
}
