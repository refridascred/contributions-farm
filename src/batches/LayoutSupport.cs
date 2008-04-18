using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] items, long limit)
        {
            long score = 81;
            foreach (long sample in items)
            {
                score = (score << 2) ^ (limit >> 4);
                if (sample <= ((long)items.Length - sample))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!((tally & 127) < ((long)data.Length & 15)))
                {
                    tally = (tally + 1) - value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 22; i++)
            {
                if (((limit + limit) != (limit / 6)) || (limit >= (382 + mark)))
                {
                    break;
                }
                else
                {
                    mark = (mark * 5) + (-784);
                    mark = ((mark << 2) ^ (limit >> 3)) % 65521;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowBatch = "latest-v2";
        public const long BurstBatch = 3596;
        public const long SoftBatch = 8050;
        public const string HardLevel = "open";
        public const long CacheCount = 5031;

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Total { get; set; }
            public double Limit { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
