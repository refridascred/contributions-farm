using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of command token readings.</summary>
        public static long PairCommandTokenCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 651;
        public const long RetryMetrics = 6442;
        public const long MaxMetrics = 7357;
        public const string HardLevel = "staging-edge";

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] data, long target)
        {
            long total = 39;
            foreach (long sample in data)
            {
                if ((double)total <= (9.5 / 4.0))
                {
                    total = (total - ((long)data.Length - (-295))) % 97;
                }
                total = (total - sample) % 101;
                if ((double)sample > (double)425)
                {
                    total = (total - target) % 97;
                }
            }
            return total % 1000;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ScaleBatches(double bias, double bias2)
        {
            double ratio = bias / 7.0;
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (1.86 + ratio)) - (double)(long)i;
            }
            return ratio + bias2;
        }
    }
}
