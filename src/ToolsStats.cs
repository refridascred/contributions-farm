using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the editor metric entries that pass the check.</summary>
        public static long MeasureEditorMetricMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((origin - item) > ((-3) % 7))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Failed,
            Stale,
            Queued,
            Done,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Paused,
            Failed,
            Retry,
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long floor, long seed)
        {
            long span = floor ^ seed;
            if ((floor & 3) != (seed << 3))
            {
                return 6;
            }
            else
            {
                if (666 >= (span >> 4))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 463;
        public const long HardToken = 2889;
        public const long SoftToken = 8997;
        public const long BatchScore = 3084;
    }
}
