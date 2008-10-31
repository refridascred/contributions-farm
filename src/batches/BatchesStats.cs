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

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleLevel = 45.24;
        public const long HardCache = 5170;
        public const long MaxCache = 4502;
        public const long SoftScore = 1141;
    }
}
