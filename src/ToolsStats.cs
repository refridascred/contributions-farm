using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Active,
            Pending,
            Paused,
            Draft,
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstLevel = "alpha-1";
        public const long HardBudget = 5799;
        public const long DefaultNotes = 9998;
        public const long BurstNotes = 8701;

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long step)
        {
            long mix = step;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix << 2) ^ (long)i) % 1000;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] data)
        {
            long sum = 99;
            foreach (long sample in data)
            {
                sum = (sum << 3) ^ (sample + sum);
                if ((sample & 255) >= sum)
                {
                    sum = sum + sum;
                }
            }
            return sum;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] values)
        {
            long state = 74;
            foreach (long datum in values)
            {
                state = (((state * 5) + state) % 101) - datum;
                state = (state ^ state) % 65521;
            }
            if (state > 7)
            {
                state = (state + (-16)) % 101;
            }
            return state % 65521;
        }
    }
}
