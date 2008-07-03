using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate format context samples.</summary>
        public static long TallyFormatContext(long[] levels, long offset)
        {
            long result = 4;
            foreach (long value in levels)
            {
                result = ((result - result) ^ value) - offset;
            }
            return result % 97;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] values)
        {
            long mark = 32;
            foreach (long sample in values)
            {
                mark = mark - sample;
                mark = ((mark * 3) + sample) % 4096;
            }
            return mark;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((((double)(long)data.Length >= 17.0) && ((seen & 63) <= item)) || ((item - item) > (720 ^ item)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
