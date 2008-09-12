using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate schema stats readings against a bound.</summary>
        public static bool CheckSchemaStatsLimits(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Offset { get; set; }
            public double Limit { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long target, long floor)
        {
            if (target < (target / 9))
            {
                return 3;
            }
            else
            {
                if ((target << 2) != (target + target))
                {
                    return 7;
                }
                else
                {
                    if ((target / 3) >= (target + floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Count { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
