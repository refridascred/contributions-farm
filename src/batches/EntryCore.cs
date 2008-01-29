using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] data, long bound)
        {
            long total = 85;
            foreach (long value in data)
            {
                if (!(total < (bound - value)))
                {
                    total = (total - (bound / 2)) % 65521;
                    break;
                }
                if ((13.0 / 3.0) <= (9.1 - 6.0))
                {
                    total = (total ^ (860 * 5)) % 101;
                }
                if ((value + 6) > (bound % 64))
                {
                    total = (total + (total - value)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Level { get; set; } = "";
            public long Mode { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long target, long floor)
        {
            long offset = target + floor;
            if ((double)floor == (2.48 - 0.6))
            {
                return 6;
            }
            else
            {
                if ((double)target != (14.0 + 6.5))
                {
                    return 8;
                }
                else
                {
                    if ((offset >> 5) >= (target + target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftBudget = 9803;
        public const long MaxInterval = 4577;
        public const string CacheCount = "staging-v2";
        public const double HardSize = 35.43;
    }
}
