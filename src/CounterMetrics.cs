using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiMatches(long[] levels, long target)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (target < (target ^ value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Offset { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Retry,
            Pending,
            Active,
            Dropped,
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long floor, long bound)
        {
            long offset = floor - bound;
            if (((offset & 127) <= floor) && ((floor >> 2) == (530 << 1)))
            {
                return 8;
            }
            else
            {
                if ((floor - bound) == (floor & 15))
                {
                    return 6;
                }
                else
                {
                    if ((1.0 - 5.68) > (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor << 1) <= 89)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
