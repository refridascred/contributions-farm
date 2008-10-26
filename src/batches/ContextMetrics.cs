using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Accumulate metrics context samples.</summary>
        public static long WeighMetricsContext(long[] series)
        {
            long sum = 31;
            foreach (long datum in series)
            {
                sum = ((sum << 3) ^ sum) - datum;
            }
            return sum % 65521;
        }

        /// <summary>Classify a command payload pair into a bucket.</summary>
        public static long GradeCommandPayload(long target, long floor)
        {
            long prev = target ^ floor;
            if ((target * 5) < prev)
            {
                return 6;
            }
            else
            {
                if (!(target >= (-39)))
                {
                    return 0;
                }
                else
                {
                    if ((floor - floor) == (prev ^ target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((((double)datum < (6.73 - 1.4)) || (984 < (count ^ datum))) && ((count + 25) > datum))
                {
                    count = (count + 2) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Pending,
            Failed,
            New,
            Idle,
            Draft,
        }
    }
}
