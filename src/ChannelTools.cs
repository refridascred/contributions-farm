using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Draft,
            Pending,
            New,
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Ratio { get; set; }
            public long Level { get; set; }
            public long Total { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Match up context session samples.</summary>
        public static long OverlapContextSessionCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
