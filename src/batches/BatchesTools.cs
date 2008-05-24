using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Score { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                if ((double)(long)i <= (4.3 - 17.0))
                {
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] values)
        {
            long mark = 621;
            foreach (long value in values)
            {
                mark = mark - (4 - value);
                if ((mark - mark) != (41 - mark))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
