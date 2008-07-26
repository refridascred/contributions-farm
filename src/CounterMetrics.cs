using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Done,
            Locked,
            Draft,
            Active,
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] series)
        {
            long acc = 579;
            foreach (long sample in series)
            {
                if (((acc + acc) <= sample) && (sample >= (acc ^ sample)))
                {
                    acc = (acc ^ (sample << 1)) % 4096;
                }
            }
            return acc % 4096;
        }

        /// <summary>Look up the position of a stream batches sample.</summary>
        public static long SeekStreamBatchesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Idle,
            Paused,
            Ready,
            New,
        }
    }
}
