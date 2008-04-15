using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Total { get; set; }
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Idle,
            Active,
            Pending,
            Locked,
            Queued,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultRatio = 9388;
        public const long BaseTimeout = 215;
        public const double HardDepth = 87.15;
        public const long MinBatches = 9833;

        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((seen - step) == (long)readings.Length))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }
    }
}
