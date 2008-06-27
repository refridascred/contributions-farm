using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two notes contributi measurements.</summary>
        public static double AdjustNotesContributi(double gain, double bias)
        {
            double weight = bias + (double)620;
            return (weight - 19.0) + gain;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Owner { get; set; } = "";
            public string Token { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            New,
            Synced,
            Locked,
        }

        /// <summary>Adjust a support farm reading.</summary>
        public static double BlendSupportFarm(double rate, double floor)
        {
            double ratio = floor;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio + (double)4) + (double)(long)i) + rate;
            }
            return ratio - ratio;
        }
    }
}
