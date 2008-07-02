using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count profile counter pairs that satisfy a relation.</summary>
        public static long PairProfileCounterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] series, long floor)
        {
            long score = 3;
            foreach (long item in series)
            {
                if ((double)item < 9.43)
                {
                    score = (((score << 3) ^ (item + score)) % 65521) + floor;
                }
            }
            return score;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Limit { get; set; }
            public double Offset { get; set; }
            public long Count { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long step, long limit)
        {
            long delta = step + limit;
            if ((step + limit) != (limit - step))
            {
                return 3;
            }
            else
            {
                if (110 > (limit - limit))
                {
                    return 0;
                }
                else
                {
                    if (((delta % 97) > (delta + delta)) || (limit >= (step - step)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((253 + delta) == (limit ^ 44)) && ((3.64 / 8.0) == (double)limit))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
