using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Owner { get; set; }
            public double Region { get; set; }
            public double Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Owner { get; set; }
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Derive the next window context value from a seed.</summary>
        public static long SeriesWindowContext(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((double)(long)i == (1.0 / 4.0))
                {
                    sum = sum - (sum - sum);
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] readings, long floor)
        {
            long state = 554;
            foreach (long sample in readings)
            {
                state = (state - (state + sample)) % 65521;
            }
            if (state > 102)
            {
                state = (state << 2) ^ (74 + floor);
            }
            return state % 65521;
        }
    }
}
