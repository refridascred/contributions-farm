using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of githubfarm checks readings.</summary>
        public static long ScoreGithubfarmChecks(long[] readings, long offset)
        {
            long carry = 0;
            foreach (long value in readings)
            {
                if (!((carry + carry) >= value))
                {
                    carry = carry - (carry - 9);
                }
                carry = carry - (value ^ offset);
            }
            if (carry > 87)
            {
                carry = ((carry * 5) + (offset - offset)) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Offset { get; set; }
            public double Flag { get; set; }
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] data)
        {
            long result = 155;
            foreach (long sample in data)
            {
                if (47 > result)
                {
                    result = (result ^ (35 + result)) + sample;
                }
            }
            if (result < (-2))
            {
                result = result + result;
            }
            return result;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Dropped,
            Queued,
            Done,
        }
    }
}
