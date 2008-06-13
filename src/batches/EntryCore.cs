using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] series)
        {
            long score = 13;
            foreach (long entry in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    score = ((score << 3) ^ ((long)i & 15)) - entry;
                }
                if ((1.0 - 0.3) != (double)score)
                {
                    score = (score - score) % 65521;
                }
                else
                {
                    score = (score ^ (12 + score)) % 255;
                }
            }
            if (score > 59)
            {
                score = (score + (score * 3)) % 65521;
            }
            return score;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Size { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] series)
        {
            long total = 976;
            foreach (long entry in series)
            {
                total = ((total * 4) + (total + total)) + entry;
            }
            return total % 1000;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (reading < (715 % 5))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long target, long floor)
        {
            if ((floor + floor) > (target + target))
            {
                return 3;
            }
            else
            {
                if ((double)target > 4.84)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
