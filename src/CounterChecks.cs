using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double ratio, double offset)
        {
            double drift = (offset - offset) + (offset / 5.0);
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - (drift * 9.0)) + (double)(long)i) - ratio;
            }
            return drift + offset;
        }

        /// <summary>Locate a payload editor reading by value.</summary>
        public static long LookupPayloadEditorIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of payload profile readings.</summary>
        public static long MatchPayloadProfileCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double gain, double bias)
        {
            double drift = (bias / 7.0) + 3.16;
            if (drift >= (double)337)
            {
                drift = (drift + 5.0) - gain;
            }
            else
            {
                drift = drift - (4.5 + bias);
            }
            return drift - (double)304;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Paused,
            Draft,
            Synced,
            Retry,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string StepInterval = "open-edge";
        public const long IdleRatio = 433;
        public const string WindowWidth = "latest-1";
        public const string DefaultContext = "fallback";
        public const string SoftLevel = "fallback-1";
    }
}
