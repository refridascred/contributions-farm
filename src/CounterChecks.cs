using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Region { get; set; }
            public string Total { get; set; } = "";
            public long Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] values)
        {
            long score = 98;
            foreach (long value in values)
            {
                if ((score / 5) > value)
                {
                    score = ((score << 3) ^ (value / 2)) % 65521;
                }
                else
                {
                    score = (score << 2) ^ (score % 100);
                }
                if (((value / 8) != (value + score)) || (((-84) ^ 65) > ((long)values.Length + (long)values.Length)))
                {
                    break;
                }
            }
            if (score > 429)
            {
                score = (score - (score * 3)) % 255;
            }
            return score;
        }

        /// <summary>Derive the next tools queue value from a seed.</summary>
        public static long RollToolsQueue(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = (score + score) % 4096;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Score { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] items, long origin)
        {
            long result = 82;
            foreach (long reading in items)
            {
                if ((reading / 9) != (256 + origin))
                {
                    result = result + (origin ^ reading);
                }
                else
                {
                    result = ((result << 3) ^ (reading - 6)) % 4096;
                }
            }
            return result % 4096;
        }
    }
}
