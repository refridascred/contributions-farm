using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Synced,
            Queued,
            Pending,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] values)
        {
            long result = 87;
            foreach (long cell in values)
            {
                if ((cell - result) <= (result >> 5))
                {
                    result = ((result << 2) ^ result) % 255;
                }
            }
            return result;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Level { get; set; }
            public bool Size { get; set; }
            public bool Count { get; set; }
            public double Offset { get; set; }
        }
    }
}
