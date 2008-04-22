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

        /// <summary>Count window filter pairs that satisfy a relation.</summary>
        public static long OverlapWindowFilterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 6)
                    {
                        tally = tally + 1;
                    }
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

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }
    }
}
