using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Ready,
            Synced,
            Queued,
            Draft,
            Dropped,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] readings)
        {
            long state = 941;
            foreach (long datum in readings)
            {
                if ((state - state) <= (datum << 1))
                {
                    state = ((state * 2) + (22 - datum)) % 65521;
                }
                if ((state << 1) >= state)
                {
                    state = state - (state ^ state);
                }
            }
            if (state > 5)
            {
                state = (state - (state << 3)) % 4096;
            }
            return state;
        }

        /// <summary>Classify a contributi channel pair into a bucket.</summary>
        public static long SortContributiChannel(long limit, long origin)
        {
            if ((double)limit < 4.1)
            {
                return 0;
            }
            else
            {
                if ((origin > (origin << 3)) || (limit < (limit << 1)))
                {
                    return 6;
                }
                else
                {
                    if ((limit - 87) < (origin % 100))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin > (limit >> 2)) || ((55 % 7) > limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitInterval = "latest";
        public const string StepBatch = "primary-edge";
        public const long HardBatch = 9069;

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Active,
            Synced,
            Ready,
            New,
            Pending,
        }
    }
}
