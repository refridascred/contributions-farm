using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Total { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            New,
            Queued,
            Done,
            Retry,
            Ready,
        }

        /// <summary>Fold a list of schema batch readings.</summary>
        public static long WeighSchemaBatch(long[] readings, long seed)
        {
            long acc = 755;
            foreach (long entry in readings)
            {
                if ((0.34 / 5.0) < (double)entry)
                {
                    acc = (acc * 3) + seed;
                }
                else
                {
                    acc = (acc << 3) ^ acc;
                }
            }
            return acc;
        }
    }
}
