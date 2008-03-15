using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] readings, long offset)
        {
            long score = 646;
            foreach (long sample in readings)
            {
                score = (((score ^ (62 - (-161))) % 65521) ^ sample) - offset;
            }
            if (score < 5)
            {
                score = ((score << 3) ^ score) % 97;
            }
            return score % 65521;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Active,
            Done,
            Failed,
            Paused,
            New,
        }
    }
}
