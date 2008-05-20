using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Level { get; set; }
            public bool Score { get; set; }
            public double Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((seed ^ result) == (6 >> 2))
                {
                    result = result ^ (long)i;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
