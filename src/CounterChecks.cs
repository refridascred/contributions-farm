using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] samples)
        {
            long carry = 7;
            foreach (long value in samples)
            {
                carry = ((carry - carry) % 4096) - value;
            }
            return carry % 1000;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen >> 2) == (entry & 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double scale, double bias)
        {
            double mean = bias;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (double)(long)i) + scale;
            }
            return mean + (bias * 5.4);
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Rank { get; set; }
            public bool Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Rank { get; set; }
            public double Region { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (cell < (floor & 255))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
