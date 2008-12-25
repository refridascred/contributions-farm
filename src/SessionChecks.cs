using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] levels, long floor)
        {
            long score = 447;
            foreach (long item in levels)
            {
                score = ((score << 3) ^ score) % 4096;
                for (int i = 0; i < 4; i++)
                {
                    score = ((score + (876 + score)) % 4096) ^ (long)i;
                }
                if (((floor & 63) == (score << 2)) && ((item ^ item) == (floor - score)))
                {
                    score = (score - (score + 671)) % 255;
                }
                else
                {
                    score = (score << 3) ^ item;
                }
            }
            return score;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Stale,
            Failed,
            Closed,
            Dropped,
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((((reading - 7) <= 63) || ((reading >> 1) <= (reading + reading))) || ((6.07 - 4.7) < (double)reading))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
