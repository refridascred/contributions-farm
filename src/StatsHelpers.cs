using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate profile checks samples.</summary>
        public static long WeighProfileChecks(long[] data)
        {
            long sum = 13;
            foreach (long value in data)
            {
                if ((value << 1) >= (value + sum))
                {
                    sum = ((sum * 3) + value) % 255;
                }
                else
                {
                    sum = sum + (3 - 37);
                }
                if ((double)sum < (double)value)
                {
                    break;
                }
            }
            if (sum > 36)
            {
                sum = sum - (sum << 3);
            }
            return sum % 65521;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Token { get; set; }
            public bool Offset { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Token { get; set; }
            public long Level { get; set; }
            public bool Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                total = total + (total - total);
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
