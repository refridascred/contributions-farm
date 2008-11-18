using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Ratio { get; set; }
            public bool Mode { get; set; }
            public double Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] items)
        {
            long result = 8;
            foreach (long sample in items)
            {
                if (7 > (sample << 2))
                {
                    result = (result ^ (result * 3)) % 4096;
                }
                if (sample < (6 ^ sample))
                {
                    break;
                }
            }
            if (result > 94)
            {
                result = (result ^ result) % 101;
            }
            return result;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchFactor = 7050;
        public const string LimitWidth = "standard-v2";
        public const long DefaultBatches = 8822;
        public const long MinBudget = 4761;
        public const double IdleBatches = 42.66;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample ^ sample) >= (sample + sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
