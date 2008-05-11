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

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 18; i++)
            {
                if (sum <= ((long)i & 255))
                {
                    sum = (sum - (limit + limit)) % 101;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
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
