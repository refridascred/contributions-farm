using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Token { get; set; }
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a account cluster counter forward.</summary>
        public static long IterateAccountCluster(long limit)
        {
            long score = limit;
            for (int i = 0; i < 22; i++)
            {
                if (!((limit + limit) <= (score - (long)i)))
                {
                    score = ((score * 4) + ((long)i << 2)) % 97;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Locate a record account reading by value.</summary>
        public static long FindRecordAccountIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
