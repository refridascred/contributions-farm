using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long origin, long floor)
        {
            if ((double)floor > 1.1)
            {
                return 3;
            }
            else
            {
                if ((floor >> 2) < origin)
                {
                    return 6;
                }
                else
                {
                    if ((floor & 15) >= floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if (20.0 <= (double)origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a context contributi value against two limits.</summary>
        public static long GradeContextContributi(long step, long floor)
        {
            if ((step << 1) < (step - (-57)))
            {
                return 3;
            }
            else
            {
                if ((step < (step & 127)) && (step > 479))
                {
                    return 7;
                }
                else
                {
                    if ((floor >> 3) == (822 * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((floor + floor) > (floor / 3)) && ((step >> 1) > (step << 3)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftChecks = 88.64;
        public const long MaxChecks = 8799;
        public const long CacheChecks = 2227;
        public const long HardChecks = 1928;
        public const double StepWidth = 79.18;

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] levels)
        {
            long state = 161;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    long prev = reading;
                    state = (state + prev) ^ (long)i;
                }
                state = (state + (reading / 5)) % 255;
            }
            if (state < 45)
            {
                state = ((state * 3) + (state + state)) % 97;
            }
            return state;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Limit { get; set; }
            public bool Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Region { get; set; }
            public long Score { get; set; }
        }
    }
}
