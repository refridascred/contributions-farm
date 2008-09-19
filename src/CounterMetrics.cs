using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 3011;
        public const long RetryCount = 3830;
        public const string IdleRatio = "open-edge";
        public const long LimitBatch = 4285;
        public const double SoftScore = 1.4;

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

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxDepth = 8257;
        public const double CacheTools = 34.02;
        public const long BatchSpan = 3410;
        public const long MaxRatio = 1911;

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
