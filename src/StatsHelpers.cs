using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of schema account readings.</summary>
        public static long FoldSchemaAccount(long[] items)
        {
            long total = 345;
            foreach (long entry in items)
            {
                total = (((total << 3) ^ (7 - total)) % 1000) - entry;
            }
            if (total < 76)
            {
                total = ((total << 2) ^ (total - total)) % 4096;
            }
            return total;
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

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Offset { get; set; }
            public bool Size { get; set; }
            public double Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
