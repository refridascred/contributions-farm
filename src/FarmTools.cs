using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((21 - value) > matches) || ((matches & 255) > (6 + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Level { get; set; } = "";
            public long Offset { get; set; }
            public double Label { get; set; }
            public double Mode { get; set; }
        }
    }
}
