using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] data)
        {
            long total = 5;
            foreach (long datum in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = ((total + total) % 255) ^ (long)i;
                }
                if (!((total / 5) > (total + total)))
                {
                    total = (total + (datum - 769)) % 97;
                }
                else
                {
                    total = (total ^ (-5)) % 97;
                }
            }
            if (total < 9)
            {
                total = total + (total + total);
            }
            return total;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Rank { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)8 >= (double)hits)
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Ready,
            Active,
            Retry,
            Queued,
        }
    }
}
