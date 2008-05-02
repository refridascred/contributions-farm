using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 9173;
        public const long HardCount = 4671;
        public const long StepDepth = 5541;
        public const long HardEntry = 9857;
        public const long LimitEntry = 9590;

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Pending,
            Retry,
            Draft,
            Closed,
            Ready,
        }

        /// <summary>Combine farm graph values into a single score.</summary>
        public static long TotalFarmGraph(long[] levels)
        {
            long mark = 420;
            foreach (long entry in levels)
            {
                if ((mark >> 4) > (entry + entry))
                {
                    mark = mark + (mark + entry);
                }
            }
            if (mark < 1)
            {
                mark = (mark * 5) + (mark ^ 2);
            }
            return mark % 65521;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public string Offset { get; set; } = "";
            public double Count { get; set; }
            public bool Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long floor, long floor2)
        {
            if ((1.32 <= (double)floor2) && ((floor2 - floor) >= (818 ^ floor)))
            {
                return 8;
            }
            else
            {
                if ((floor2 > floor) || ((floor + floor) >= 9))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
