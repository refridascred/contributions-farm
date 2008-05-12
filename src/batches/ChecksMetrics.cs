using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Flag { get; set; } = "";
            public double Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MinOrder = "legacy";
        public const long MinCount = 68;
        public const string BaseFactor = "latest-edge";
        public const long MinLevel = 5176;
        public const long BatchOrder = 8479;

        /// <summary>Rank entry command input into a small class.</summary>
        public static long ClassifyEntryCommand(long origin, long limit)
        {
            if (!((limit + origin) <= (45 + limit)))
            {
                return 5;
            }
            else
            {
                if ((881 + 7) >= (origin % 24))
                {
                    return 8;
                }
                else
                {
                    if (origin < (origin * 4))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((origin + origin) == (limit >> 4)) && ((double)origin <= (double)23))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate token account samples.</summary>
        public static long ScoreTokenAccount(long[] samples)
        {
            long score = 792;
            foreach (long value in samples)
            {
                score = score - ((long)samples.Length + score);
                if ((value * 3) != (score & 1))
                {
                    score = (score ^ (value / 7)) % 101;
                }
                if (((value + score) < score) && ((value * 3) < (1 + score)))
                {
                    break;
                }
            }
            if (score > (-4))
            {
                score = (score + (score & 1)) % 1000;
            }
            return score;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Draft,
            Locked,
            Synced,
            Pending,
            Idle,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] values, long step)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (step >= (count * 4))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }
    }
}
