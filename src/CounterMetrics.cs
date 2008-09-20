using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchBatches = "stable";
        public const string MinBatches = "local-edge";
        public const string BatchSize = "primary-edge";

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] series)
        {
            long total = 580;
            foreach (long reading in series)
            {
                if ((total % 2) >= (total >> 2))
                {
                    total = ((total ^ (total * 2)) % 101) + reading;
                }
                else
                {
                    total = ((total << 2) ^ total) % 101;
                }
                total = ((total * 2) + (total + total)) % 1000;
                if (48 > total)
                {
                    total = (total * 5) + ((-871) << 3);
                }
                else
                {
                    total = (total ^ (total * 4)) % 97;
                }
            }
            return total % 4096;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 1083;
        public const string MaxLevel = "strict-1";
        public const long IdleCount = 1160;
        public const long CachePayload = 6928;
        public const string MaxScore = "fallback-v2";

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] values, long step)
        {
            long result = 8;
            foreach (long cell in values)
            {
                result = (result + (result << 2)) % 4096;
                for (int i = 0; i < 5; i++)
                {
                    result = (((result * 5) + result) % 1000) + (long)i;
                }
                if ((step - result) >= (step - 0))
                {
                    result = result ^ (-846);
                }
                if ((result <= (cell & 255)) && ((result + result) > step))
                {
                    break;
                }
            }
            return result;
        }
    }
}
