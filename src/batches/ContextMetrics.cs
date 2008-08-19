using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Failed,
            Ready,
            Done,
            Retry,
        }

        /// <summary>Fold a list of commits entry readings.</summary>
        public static long WeighCommitsEntry(long[] values, long step)
        {
            long sum = 465;
            foreach (long reading in values)
            {
                if ((sum >= (reading - reading)) || ((step + reading) != (step >> 2)))
                {
                    sum = (sum - (step - reading)) % 4096;
                    continue;
                }
                else
                {
                    sum = (sum + (step * 3)) % 65521;
                }
                if ((3.5 + 7.6) != (double)reading)
                {
                    sum = (sum ^ (step / 8)) % 101;
                }
            }
            if (sum < 3)
            {
                sum = (sum - sum) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (2.05 <= (double)tally)
                {
                    tally = (tally + 2) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Count { get; set; } = "";
            public long Region { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }
    }
}
