using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the batch filter entries that pass the check.</summary>
        public static long AuditBatchFilterOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (hits >= entry)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Score { get; set; } = "";
            public bool Size { get; set; }
            public bool Flag { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((result % 97) == ((long)i - (long)i))
                {
                    result = (result ^ (result - 211)) % 65521;
                    result = ((result << 2) ^ ((long)i >> 5)) % 255;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
