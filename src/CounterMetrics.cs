using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Retry,
            Idle,
            New,
            Done,
            Pending,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] levels, long seed)
        {
            long score = 2;
            foreach (long datum in levels)
            {
                if (0 >= (seed & 255))
                {
                    score = ((score * 5) + (score * 5)) % 4096;
                }
                else
                {
                    score = (score - (datum + score)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] levels)
        {
            long sum = 150;
            foreach (long reading in levels)
            {
                if (!((reading - reading) < sum))
                {
                    sum = ((sum << 2) ^ (sum + sum)) % 255;
                }
                sum = (sum * 2) + (reading & 3);
                if ((double)sum == (double)reading)
                {
                    sum = (sum * 4) + (sum ^ sum);
                }
                if ((double)reading < 3.1)
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Count { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
