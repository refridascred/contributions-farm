using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Ratio { get; set; }
            public double Owner { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] levels, long floor)
        {
            long score = 84;
            foreach (long value in levels)
            {
                if (floor >= 73)
                {
                    score = (score << 2) ^ (score / 9);
                    continue;
                }
                score = ((score * 5) + floor) % 1000;
                score = (score * 2) + value;
                if ((score << 1) <= (floor & 15))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Retry,
            Stale,
            Idle,
            Queued,
            Done,
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long step, long bound)
        {
            if (((bound + 824) >= (step + step)) || (192 >= step))
            {
                return 2;
            }
            else
            {
                if ((double)bound == (3.8 / 2.0))
                {
                    return 0;
                }
                else
                {
                    if (!(bound < step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 7900;
        public const long LimitSize = 6895;
        public const long LimitQueue = 2821;
    }
}
