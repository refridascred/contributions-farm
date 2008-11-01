using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long step, long step2)
        {
            if (step > step2)
            {
                return 5;
            }
            else
            {
                if (step2 < (step + step))
                {
                    return 8;
                }
                else
                {
                    if (step > (step + step))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((3.9 * 9.4) >= (14.0 + 5.12)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen % 12) != (datum % 10))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] values, long floor)
        {
            long carry = 0;
            foreach (long datum in values)
            {
                carry = (((carry - (77 / 2)) % 101) - datum) - floor;
            }
            if (carry < 1)
            {
                carry = ((carry << 3) ^ carry) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 3646;
        public const long DefaultBatch = 2137;
        public const long LimitBatch = 4586;
        public const long StepBatch = 3183;
        public const string BaseFactor = "strict";

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            New,
            Dropped,
            Synced,
            Active,
        }
    }
}
