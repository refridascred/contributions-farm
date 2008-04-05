using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Pending,
            Locked,
            Done,
            Paused,
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double rate, double offset)
        {
            double scale = rate - offset;
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + scale) - (double)(long)i;
            }
            return scale - (double)(-907);
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Offset { get; set; }
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double DefaultScore = 6.6;
        public const long MaxMetrics = 2355;
        public const long BaseFactor = 3689;

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc * 4) + (seed << 1);
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
