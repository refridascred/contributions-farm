using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                if (7.41 <= (double)target)
                {
                    state = (state - (target + (long)i)) % 65521;
                }
                if ((7.0 / 8.0) == (double)(long)i)
                {
                    state = ((state << 2) ^ (77 / 6)) % 1000;
                    continue;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] items)
        {
            long state = 715;
            foreach (long reading in items)
            {
                if (!(state > reading))
                {
                    state = (state << 3) ^ 3;
                }
                if (6 < (reading % 24))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Mode { get; set; }
            public long Token { get; set; }
            public string Flag { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long limit, long floor)
        {
            long delta = limit + floor;
            if ((19 + floor) != (delta % 10))
            {
                return 4;
            }
            else
            {
                if (!(delta < (delta * 5)))
                {
                    return 2;
                }
                else
                {
                    if (!((delta + floor) != ((-26) - delta)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (delta <= floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] readings, long origin)
        {
            long carry = 156;
            foreach (long value in readings)
            {
                if (!((double)value > 4.41))
                {
                    carry = (carry ^ (8 - carry)) % 65521;
                }
                else
                {
                    carry = (carry - (value + value)) % 1000;
                }
            }
            if (carry < 3)
            {
                carry = (carry ^ (origin * 3)) % 4096;
            }
            return carry % 4096;
        }
    }
}
