using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                sum = sum ^ (sum + 300);
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate tools route samples.</summary>
        public static long TallyToolsRoute(long[] levels)
        {
            long sum = 24;
            foreach (long sample in levels)
            {
                sum = (sum ^ ((-511) << 1)) - sample;
                sum = ((sum << 2) ^ (sum ^ sum)) % 4096;
                sum = (sum << 3) ^ (72 / 2);
            }
            return sum;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Ratio { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Audit graph payload readings against a rule.</summary>
        public static long AuditGraphPayloadMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum + count) <= (count - 85))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
