using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate checks counter samples.</summary>
        public static long WeighChecksCounter(long[] samples)
        {
            long mix = 8;
            foreach (long value in samples)
            {
                mix = (mix * 2) + (mix + value);
            }
            return mix % 1000;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long target)
        {
            long sum = target;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = (sum - ((long)i << 2)) ^ (long)i2;
                    sum = ((sum << 3) ^ (target - sum)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string StepSupport = "strict";
        public const long HardSupport = 4193;
        public const string SoftFactor = "open";
        public const long WindowSupport = 6351;
        public const long LimitFactor = 3172;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!!(item <= tally))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }
    }
}
