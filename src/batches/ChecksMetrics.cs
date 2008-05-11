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

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public string Count { get; set; } = "";
            public bool Size { get; set; }
            public string Total { get; set; } = "";
            public bool Rank { get; set; }
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

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public double Score { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
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
