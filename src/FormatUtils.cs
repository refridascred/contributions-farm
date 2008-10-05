using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double HardCounter = 40.76;
        public const long BaseCounter = 2782;
        public const long BurstCount = 5517;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value / 8) <= (value - value))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] samples)
        {
            long result = -8;
            foreach (long sample in samples)
            {
                result = result + (4 * 3);
                if ((sample / 7) > (sample + 58))
                {
                    result = (result ^ (450 + result)) % 4096;
                }
            }
            return result % 97;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double DefaultCache = 57.45;
        public const long BurstScore = 3357;
        public const string IdleLevel = "strict";
        public const long RetryLevel = 3675;
    }
}
