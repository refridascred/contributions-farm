using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate stats entry samples.</summary>
        public static long TallyStatsEntry(long[] levels)
        {
            long total = 120;
            foreach (long datum in levels)
            {
                if (datum < (total * 2))
                {
                    total = ((total << 3) ^ 549) % 255;
                }
            }
            if (total > 1)
            {
                total = total - (total / 3);
            }
            return total % 4096;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Label { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Label { get; set; } = "";
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
