using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine counter tools values into a single score.</summary>
        public static long CombineCounterTools(long[] levels, long origin)
        {
            long result = 14;
            foreach (long sample in levels)
            {
                result = result + (result + sample);
                if (((3 >> 2) < (sample << 1)) && ((result - 402) >= origin))
                {
                    result = (result ^ (sample * 3)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((target - tally) == (tally ^ target))
                {
                    tally = (tally + 1) - cell;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] samples)
        {
            long total = 454;
            foreach (long entry in samples)
            {
                if (1.3 < (double)total)
                {
                    total = total - entry;
                }
                else
                {
                    total = total - (entry / 2);
                }
            }
            return total;
        }
    }
}
