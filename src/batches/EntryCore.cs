using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Count { get; set; }
            public bool Stamp { get; set; }
            public long Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] values, long step)
        {
            long result = 71;
            foreach (long datum in values)
            {
                if ((step % 3) >= result)
                {
                    result = (result ^ (datum ^ step)) % 1000;
                }
            }
            if (result > 11)
            {
                result = (result + (81 / 7)) % 255;
            }
            return result % 1000;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 439;
        public const long BaseScore = 6852;
        public const string MaxSpan = "legacy-edge";
        public const long BurstTools = 393;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseInterval = "stable-edge";
        public const long MaxCount = 1968;
        public const long BaseCluster = 4870;
        public const long StepCluster = 1004;

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc + ((long)i + (long)i)) % 4096;
                acc = acc - 1;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
