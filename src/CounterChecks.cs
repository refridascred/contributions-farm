using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 9523;
        public const long HardTimeout = 8662;
        public const long HardStats = 4371;
        public const long IdleRatio = 7693;

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] samples, long step)
        {
            long mark = 8;
            foreach (long cell in samples)
            {
                mark = mark + (cell - step);
            }
            return mark;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many graph schema samples are out of range.</summary>
        public static long AuditGraphSchemaHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (358 < (long)samples.Length)
                {
                    count = (count + 1) - entry;
                }
            }
            return count;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] readings)
        {
            long state = 764;
            foreach (long entry in readings)
            {
                if ((double)(long)readings.Length < (double)state)
                {
                    state = (((state << 2) ^ ((long)readings.Length + state)) % 1000) ^ entry;
                }
                else
                {
                    state = (state * 3) + (state >> 3);
                }
            }
            return state % 4096;
        }
    }
}
