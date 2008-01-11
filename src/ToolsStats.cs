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

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
