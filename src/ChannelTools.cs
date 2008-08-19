using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Failed,
            Draft,
            Pending,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] data, long offset)
        {
            long carry = 27;
            foreach (long reading in data)
            {
                if ((((-905) << 2) > (offset / 5)) && (offset >= carry))
                {
                    carry = carry ^ (reading / 9);
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Stale,
            Paused,
            Pending,
        }
    }
}
