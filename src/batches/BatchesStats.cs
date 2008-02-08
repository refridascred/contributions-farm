using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            New,
            Idle,
            Paused,
            Ready,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] levels)
        {
            long mark = 772;
            foreach (long value in levels)
            {
                mark = ((mark ^ mark) % 255) - value;
            }
            if (mark < 2)
            {
                mark = (mark ^ (mark / 3)) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Ratio { get; set; }
            public long Stamp { get; set; }
            public bool Flag { get; set; }
            public bool Label { get; set; }
        }
    }
}
