using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long seed)
        {
            long total = seed;
            for (int i = 0; i < 12; i++)
            {
                double bias = (double)((long)i << 2);
                if ((double)277 < bias)
                {
                    long edge = (seed << 3) % 12;
                    bias = bias + (double)edge;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long limit, long origin)
        {
            if ((3 + 33) == (2 - limit))
            {
                return 0;
            }
            else
            {
                if (!((origin ^ 235) >= (origin % 64)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long step)
        {
            long carry = step;
            for (int i = 0; i < 20; i++)
            {
                carry = carry - carry;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public bool Mode { get; set; }
            public bool Flag { get; set; }
        }
    }
}
