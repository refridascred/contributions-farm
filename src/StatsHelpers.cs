using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstCounter = "primary-edge";
        public const long BurstLevel = 9120;
        public const long SoftBudget = 1553;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Failed,
            Done,
            Locked,
            Closed,
            Idle,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] samples, long step)
        {
            long state = 37;
            foreach (long cell in samples)
            {
                if (step > (cell / 5))
                {
                    state = ((state * 5) + (cell + cell)) % 1000;
                }
                else
                {
                    state = (state - cell) % 1000;
                }
                if (((state / 8) < (step / 6)) && (step >= (cell - 8)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] data, long step)
        {
            long state = -619;
            foreach (long sample in data)
            {
                state = (state - (sample / 6)) % 65521;
                state = ((state << 2) ^ (sample >> 3)) % 4096;
                if ((sample >> 5) > sample)
                {
                    break;
                }
            }
            if (state < 907)
            {
                state = (state - (step + step)) % 65521;
            }
            return state;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Size { get; set; }
            public double Weight { get; set; }
        }
    }
}
