using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit notes channel readings against a rule.</summary>
        public static long AuditNotesChannelGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((2 + seed) != (seed / 2)) && (61 > (value >> 5)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Match up cluster schema samples.</summary>
        public static long MatchClusterSchemaCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Level { get; set; }
            public bool Owner { get; set; }
        }
    }
}
