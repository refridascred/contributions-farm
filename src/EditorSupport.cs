using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 9321;
        public const long HardWindow = 9494;
        public const long DefaultBudget = 5995;
        public const long IdleWindow = 925;
        public const string BaseWindow = "open-1";

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Ready,
            Paused,
            Pending,
            Draft,
            Locked,
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Ratio { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Classify a route counter pair into a bucket.</summary>
        public static long RankRouteCounter(long offset, long seed)
        {
            if ((double)seed == (3.0 - 8.2))
            {
                return 6;
            }
            else
            {
                if (!((double)seed <= (double)offset))
                {
                    return 1;
                }
                else
                {
                    if (offset <= (offset / 9))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((offset % 16) <= (29 + offset)) && ((offset % 10) >= (seed ^ offset)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long limit)
        {
            long score = limit;
            for (int i = 0; i < 14; i++)
            {
                score = score - 61;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] readings)
        {
            long state = 8;
            foreach (long reading in readings)
            {
                state = (state ^ (state - (long)readings.Length)) ^ reading;
                if ((double)state >= 8.12)
                {
                    state = state - 1;
                }
            }
            if (state > 15)
            {
                state = state - state;
            }
            return state % 1000;
        }
    }
}
