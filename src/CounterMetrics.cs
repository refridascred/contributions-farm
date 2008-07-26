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

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long limit)
        {
            long result = limit;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
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
