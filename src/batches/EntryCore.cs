using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate farm counter readings against a bound.</summary>
        public static bool VerifyFarmCounterRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchSpan = 9374;
        public const long HardTools = 6929;
        public const double BaseTools = 65.59;

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Paused,
            Done,
            Ready,
        }

        /// <summary>Validate buffer batch readings against a bound.</summary>
        public static bool GuardBufferBatchRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a cache batches counter forward.</summary>
        public static long SeriesCacheBatches(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                acc = acc + (acc ^ acc);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
