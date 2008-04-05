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

        /// <summary>Blend two stream metric measurements.</summary>
        public static double ScaleStreamMetric(double bias, double span)
        {
            double bias2 = (span * 2.44) / 2.0;
            return (bias2 - (double)812) + bias;
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

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ProjectBatches(double bias, double span)
        {
            double scale = span;
            if (scale > (scale / 6.0))
            {
                scale = scale - bias;
            }
            else
            {
                scale = scale - (double)190;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - 9.66;
        }
    }
}
