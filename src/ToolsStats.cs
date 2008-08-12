using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long floor, long floor2)
        {
            if ((floor / 3) == (floor / 4))
            {
                return 8;
            }
            else
            {
                if ((71 % 12) < (floor * 2))
                {
                    return 5;
                }
                else
                {
                    if (floor <= (floor2 / 8))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((-60) >= floor2)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank context profile input into a small class.</summary>
        public static long GradeContextProfile(long target, long origin)
        {
            if ((target << 3) != (origin & 63))
            {
                return 7;
            }
            else
            {
                if (((origin >> 3) < (8 & 127)) || ((target & 1) != (origin >> 5)))
                {
                    return 2;
                }
                else
                {
                    if ((origin + target) <= (origin >> 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Region { get; set; } = "";
            public double Flag { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Combine contributi entry values into a single score.</summary>
        public static long FoldContributiEntry(long[] values, long target)
        {
            long score = 567;
            foreach (long entry in values)
            {
                if ((2 <= (target + score)) || ((entry << 3) <= score))
                {
                    score = (score * 4) + 95;
                }
            }
            return score % 97;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Token { get; set; }
            public long Count { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
