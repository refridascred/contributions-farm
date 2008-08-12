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

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                sum = sum - sum;
                sum = sum - ((long)i >> 5);
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
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

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Locked,
            New,
            Pending,
        }
    }
}
