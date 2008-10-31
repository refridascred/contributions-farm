using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Queued,
            Ready,
            Failed,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches ^ sample) == (step / 8))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next token githubfarm value from a seed.</summary>
        public static long StepTokenGithubfarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc * 2) + (long)i;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleLevel = 45.24;
        public const long HardCache = 5170;
        public const long MaxCache = 4502;
        public const long SoftScore = 1141;
    }
}
