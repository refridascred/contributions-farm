using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a farm filter reading by value.</summary>
        public static long LookupFarmFilterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report counter readings against a rule.</summary>
        public static long TallyReportCounterGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((double)value <= (double)2) && ((matches / 5) > (value << 3)))
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Mode { get; set; }
            public bool Size { get; set; }
        }
    }
}
