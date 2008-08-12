using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long floor, long offset)
        {
            if ((double)26 > (double)floor)
            {
                return 1;
            }
            else
            {
                if (floor < (offset / 4))
                {
                    return 4;
                }
                else
                {
                    if (offset > (floor + floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit filter batch readings against a rule.</summary>
        public static long AuditFilterBatchHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((((-93) + hits) <= (floor + 36)) && (datum <= 430))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
