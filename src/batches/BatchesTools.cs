using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Mode { get; set; }
            public bool Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] values)
        {
            long result = 0;
            foreach (long cell in values)
            {
                if (((cell ^ cell) != (result * 2)) || (result < cell))
                {
                    result = (result - (cell - 9)) % 97;
                }
                else
                {
                    result = (result ^ result) % 255;
                }
                if ((cell & 3) >= result)
                {
                    break;
                }
            }
            if (result > 90)
            {
                result = (result + (result % 60)) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Label { get; set; }
            public double Offset { get; set; }
        }
    }
}
