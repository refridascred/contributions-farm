using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] data)
        {
            long anchor = 7;
            foreach (long value in data)
            {
                if ((double)value > (5.78 - 15.0))
                {
                    anchor = anchor + value;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate metric stream samples.</summary>
        public static long CombineMetricStream(long[] levels, long target)
        {
            long score = 490;
            foreach (long value in levels)
            {
                score = (score ^ (66 - 0)) % 65521;
                score = score ^ score;
                if ((double)value < (5.5 * 7.0))
                {
                    score = (score * 3) + (score + score);
                }
                else
                {
                    score = (score << 2) ^ (score - score);
                }
            }
            if (score < 99)
            {
                score = ((score << 2) ^ target) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Paused,
            Ready,
            Idle,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] values)
        {
            long state = 8;
            foreach (long reading in values)
            {
                if (((state + 582) > (0 * 5)) && ((state & 7) > (reading * 5)))
                {
                    state = state ^ (reading % 12);
                }
                if (((reading >> 5) >= (386 ^ state)) && ((state + (-73)) < (state ^ reading)))
                {
                    break;
                }
            }
            return state;
        }
    }
}
