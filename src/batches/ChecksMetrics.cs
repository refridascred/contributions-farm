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

        /// <summary>Validate command token readings against a bound.</summary>
        public static bool CheckCommandTokenRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
