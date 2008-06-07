using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Mode { get; set; }
            public double Score { get; set; }
            public bool Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum ^ (86 >> 4)) % 97;
                sum = (sum - 394) % 1000;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Audit graph account readings against a rule.</summary>
        public static long MeasureGraphAccountOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((floor + reading) == (matches + reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the buffer batch entries that pass the check.</summary>
        public static long TallyBufferBatchGaps(long[] series, long offset)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)45 == (double)sample)
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((count << 3) == (reading + count)) && ((24 ^ count) < (count ^ 114)))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Stale,
            Ready,
            Synced,
        }
    }
}
