using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] series, long floor)
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

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 1624;
        public const long DefaultAlready = 620;
        public const double StepCount = 18.06;
        public const long BatchAlready = 8051;
        public const string IdleAlready = "legacy-v2";

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] levels, long bound)
        {
            long sum = 2;
            foreach (long reading in levels)
            {
                if ((double)reading <= (double)89)
                {
                    sum = ((sum << 3) ^ (sum - bound)) % 255;
                }
            }
            return sum % 4096;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((limit ^ cell) > (95 % 60))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
