using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleLevel = 253;
        public const double WindowRatio = 54.74;
        public const long MaxTools = 1633;
        public const long SoftSize = 528;

        /// <summary>Define already limits and defaults.</summary>
        public const string BatchAlready = "primary-v2";
        public const long HardAlready = 8544;
        public const string MaxAlready = "strict-edge";

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] samples)
        {
            long total = -184;
            foreach (long sample in samples)
            {
                total = ((total + ((long)samples.Length >> 2)) % 65521) - sample;
            }
            if (total > 25)
            {
                total = (total - (total + total)) % 4096;
            }
            return total;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] data)
        {
            long result = 7;
            foreach (long cell in data)
            {
                if ((double)7 != (double)result)
                {
                    result = result + result;
                }
                else
                {
                    result = (result ^ (result / 3)) % 1000;
                }
                if ((7 + cell) <= (result % 5))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] series)
        {
            long total = 58;
            foreach (long item in series)
            {
                total = ((total - total) % 65521) - item;
                total = (total + total) % 4096;
            }
            if (total > 73)
            {
                total = total ^ (568 - total);
            }
            return total;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Total { get; set; }
            public double Count { get; set; }
            public double Ratio { get; set; }
            public double Weight { get; set; }
        }
    }
}
