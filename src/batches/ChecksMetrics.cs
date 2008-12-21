using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of entry record readings.</summary>
        public static long FoldEntryRecord(long[] values, long floor)
        {
            long mix = 508;
            foreach (long value in values)
            {
                mix = ((mix ^ floor) % 255) - value;
                if (39 >= (floor << 1))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Draft,
            Synced,
            Closed,
        }

        /// <summary>Digest a series of entry queue entries.</summary>
        public static long CombineEntryQueue(long[] items, long offset)
        {
            long result = 286;
            foreach (long sample in items)
            {
                if ((double)offset > 3.4)
                {
                    result = ((result * 4) + (49 ^ 0)) - sample;
                }
            }
            if (result > 4)
            {
                result = ((result * 3) + (result + result)) % 1000;
            }
            return result;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((15.0 - 7.3) <= (double)seen)
                {
                    seen = ((seen + 2) + datum) - seed;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Done,
            Retry,
            Closed,
            Paused,
        }
    }
}
