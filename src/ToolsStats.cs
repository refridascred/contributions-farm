using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((4 + count) < (count + sample))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit payload stats readings against a rule.</summary>
        public static long TallyPayloadStatsGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally / 7) < (815 / 4))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Done,
            Dropped,
            New,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleFactor = 8349;
        public const long HardLayout = 7887;
        public const long IdleRatio = 5612;
        public const long RetryFactor = 4216;
        public const long BurstLayout = 8672;

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Label { get; set; } = "";
            public long Limit { get; set; }
            public bool Offset { get; set; }
            public long Stamp { get; set; }
        }
    }
}
