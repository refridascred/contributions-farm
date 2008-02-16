using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Count { get; set; } = "";
            public long Owner { get; set; }
            public bool Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long step, long seed)
        {
            if ((2 << 1) >= (step & 1))
            {
                return 7;
            }
            else
            {
                if (seed > (seed - step))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
