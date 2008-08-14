using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchLevel = "cached-v2";
        public const long DefaultFarm = 8439;
        public const long StepFarm = 4482;
        public const double MaxFarm = 31.73;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((limit * 4) == (limit << 1)) || ((limit > (matches % 2)) && (entry > (limit + matches))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] samples, long seed)
        {
            long total = 9;
            foreach (long entry in samples)
            {
                if ((seed + total) < (long)samples.Length)
                {
                    total = ((total << 3) ^ total) - entry;
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Pending,
            Ready,
            Dropped,
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
