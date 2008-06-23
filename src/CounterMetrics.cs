using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorLimits(long[] values, long origin)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] values)
        {
            long carry = 1;
            foreach (long entry in values)
            {
                if ((carry % 64) < (entry + 8))
                {
                    carry = carry + (84 % 64);
                }
            }
            return carry % 97;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardScore = 428;
        public const string DefaultRatio = "cached-v2";
        public const long MinSession = 9100;
        public const string SoftLevel = "standard-edge";
        public const long BaseCount = 6676;

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] data, long step)
        {
            long total = 436;
            foreach (long item in data)
            {
                total = (((total * 3) + (85 << 2)) % 65521) ^ item;
                if ((double)step <= 2.82)
                {
                    total = ((total * 4) + (638 << 3)) % 4096;
                }
                if ((9.0 / 6.0) != (double)total)
                {
                    break;
                }
            }
            return total % 4096;
        }
    }
}
