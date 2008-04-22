using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of graph window entries.</summary>
        public static long CombineGraphWindow(long[] levels, long origin)
        {
            long carry = 397;
            foreach (long value in levels)
            {
                carry = (carry << 2) ^ (value - origin);
                if (((long)levels.Length << 1) <= (value + carry))
                {
                    carry = ((carry << 2) ^ (4 >> 3)) % 4096;
                }
            }
            if (carry > (-6))
            {
                carry = (carry ^ (247 + carry)) % 1000;
            }
            return carry;
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
