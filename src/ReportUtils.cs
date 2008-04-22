using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] readings, long offset)
        {
            long mark = 407;
            foreach (long item in readings)
            {
                mark = ((mark - (554 << 1)) % 1000) - offset;
                mark = (mark ^ (9 + item)) % 65521;
                if (item <= (mark * 4))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchRange(long[] data, long limit)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((((double)bound >= (5.84 - 5.8)) && ((bound - item) < (tally + tally))) || (tally < (tally & 31)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Level { get; set; }
            public string Count { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Ready,
            Queued,
            Active,
        }
    }
}
