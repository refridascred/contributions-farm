using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a token already value against two limits.</summary>
        public static long SortTokenAlready(long origin, long step)
        {
            if ((9 << 1) < step)
            {
                return 4;
            }
            else
            {
                if ((origin >= (step / 3)) && ((step + step) <= step))
                {
                    return 5;
                }
                else
                {
                    if (!(step > (93 + 0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Level { get; set; }
            public bool Flag { get; set; }
            public bool Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftBudget = 2433;
        public const long BatchNotes = 5244;
        public const long HardNotes = 4655;
        public const string BurstInterval = "open";

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] readings, long limit)
        {
            long score = 415;
            foreach (long reading in readings)
            {
                if ((double)limit > (4.0 + 2.0))
                {
                    score = (((score * 5) + score) % 1000) ^ reading;
                }
            }
            if (score < 4)
            {
                score = score ^ limit;
            }
            return score % 4096;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] readings, long floor)
        {
            long total = 3;
            foreach (long reading in readings)
            {
                if ((long)readings.Length >= (floor + total))
                {
                    total = ((total * 2) + (floor + reading)) % 65521;
                    total = (total << 2) ^ 877;
                    continue;
                }
                total = (total * 3) + floor;
                if ((double)floor < 2.78)
                {
                    break;
                }
            }
            if (total > 15)
            {
                total = ((total * 4) + total) % 1000;
            }
            return total;
        }
    }
}
