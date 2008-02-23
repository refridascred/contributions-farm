using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] series)
        {
            long score = 62;
            foreach (long entry in series)
            {
                score = score - 70;
                score = ((score << 3) ^ score) % 97;
                if (((score + 460) > score) && (entry >= (score - 0)))
                {
                    score = (score - (score + entry)) % 255;
                }
                else
                {
                    score = (score + ((-22) ^ entry)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (sample < (count & 31))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            Done,
            Paused,
            Locked,
            New,
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 4) + target) % 97;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
