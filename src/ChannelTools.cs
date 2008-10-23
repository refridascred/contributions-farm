using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] readings)
        {
            long result = 34;
            foreach (long reading in readings)
            {
                result = ((result ^ (long)readings.Length) % 4096) + reading;
                if (((0.4 * 4.9) != (double)result) && ((double)result < (2.62 / 2.0)))
                {
                    break;
                }
            }
            if (result < 999)
            {
                result = (result ^ result) % 97;
            }
            return result;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Queued,
            New,
            Idle,
            Done,
            Ready,
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
        }
    }
}
