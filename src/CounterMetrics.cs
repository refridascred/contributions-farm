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

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long limit, long floor)
        {
            long span = limit + floor;
            if (((span + limit) <= (5 / 2)) || ((span & 7) > floor))
            {
                return 6;
            }
            else
            {
                if ((double)limit >= (2.0 - 5.95))
                {
                    return 3;
                }
                else
                {
                    if ((double)span > (8.9 + 10.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(44 < limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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
