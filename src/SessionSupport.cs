using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Level { get; set; }
            public bool Score { get; set; }
            public long Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((long)values.Length & 127) == (entry * 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
