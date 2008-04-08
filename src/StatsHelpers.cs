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

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long floor, long step)
        {
            if ((double)step > 9.41)
            {
                return 8;
            }
            else
            {
                if ((floor << 3) == (step - floor))
                {
                    return 5;
                }
                else
                {
                    if (((floor + step) > 253) || ((0.28 - 1.0) > (double)floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)step < (5.1 * 2.9))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
