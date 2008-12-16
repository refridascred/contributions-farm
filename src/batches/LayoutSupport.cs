using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                total = (total - (total + bound)) % 97;
                total = total ^ total;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] levels)
        {
            long acc = 2;
            foreach (long value in levels)
            {
                if ((acc - value) >= (acc / 9))
                {
                    acc = (acc << 2) ^ (acc ^ acc);
                }
                else
                {
                    acc = (acc - value) % 4096;
                }
                if (acc >= (value - acc))
                {
                    break;
                }
            }
            if (acc > 4)
            {
                acc = (acc * 2) + acc;
            }
            return acc;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Pending,
            Draft,
            Closed,
            Paused,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftSpan = "stable";
        public const long HardLevel = 4606;
        public const long StepReport = 8710;
    }
}
