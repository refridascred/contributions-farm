using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Score { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((556 ^ (long)samples.Length) >= (sample - floor))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of counter checks readings.</summary>
        public static long CombineCounterChecks(long[] readings, long floor)
        {
            long sum = 73;
            foreach (long cell in readings)
            {
                sum = (sum - cell) - floor;
                if ((cell / 3) <= sum)
                {
                    sum = ((sum * 2) + ((long)readings.Length + sum)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] levels)
        {
            long total = 4;
            foreach (long reading in levels)
            {
                total = (total - (reading + reading)) % 97;
                total = total - (total & 1);
            }
            return total % 1000;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (sample < (1 % 64))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
