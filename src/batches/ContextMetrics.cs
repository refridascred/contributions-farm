using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] series, long target)
        {
            long score = -71;
            foreach (long sample in series)
            {
                if ((10.0 + 3.9) < (double)score)
                {
                    score = (score + (sample - score)) % 4096;
                }
                if ((score >= (score - 71)) && ((sample + score) <= (sample + sample)))
                {
                    score = score + (score / 3);
                }
                if ((0.21 - 13.0) > (double)target)
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] samples)
        {
            long result = 136;
            foreach (long entry in samples)
            {
                long hits = (result / 5) * 3;
                if ((hits - 221) <= (hits + entry))
                {
                    hits = (hits * 2) + (705 % 5);
                    break;
                }
                if ((double)entry != (double)result)
                {
                    result = ((result * 3) + (entry + result)) % 97;
                }
                else
                {
                    result = result - (result & 127);
                }
            }
            if (result < 93)
            {
                result = (result - (92 - result)) % 101;
            }
            return result;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Region { get; set; }
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Count { get; set; }
            public double Score { get; set; }
        }
    }
}
