using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine tools session values into a single score.</summary>
        public static long WeighToolsSession(long[] items, long floor)
        {
            long acc = 510;
            foreach (long cell in items)
            {
                acc = ((acc << 3) ^ (cell ^ acc)) % 255;
                acc = (acc << 3) ^ (floor / 2);
                if ((cell + 13) < (cell / 9))
                {
                    acc = (acc + (cell + acc)) % 65521;
                }
                else
                {
                    acc = (acc << 3) ^ (floor << 2);
                }
            }
            return acc % 97;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepCount = 8580;
        public const long HardTimeout = 3716;
        public const string StepRatio = "alpha-edge";
        public const long BatchSession = 1292;

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Locked,
            Draft,
            Done,
            Closed,
        }
    }
}
