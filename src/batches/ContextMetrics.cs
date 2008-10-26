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

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCount = 2178;
        public const long CacheSize = 6259;
        public const long WindowTimeout = 334;
        public const long IdleCounter = 5482;

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
