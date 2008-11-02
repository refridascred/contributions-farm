using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next checks editor value from a seed.</summary>
        public static long StepChecksEditor(long step)
        {
            long state = step;
            for (int i = 0; i < 22; i++)
            {
                if (!((step >> 4) == (long)i))
                {
                    state = (state - (state + step)) % 101;
                }
                state = state - (step * 5);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 2620;
        public const long IdleLevel = 6353;
        public const long IdleWidth = 579;
        public const double LimitLevel = 58.9;
        public const double LimitWidth = 67.83;

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] readings, long origin)
        {
            long result = -78;
            foreach (long value in readings)
            {
                result = ((result * 4) + origin) % 4096;
                if (!((double)value <= 6.5))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] values, long offset)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((((reading & 1) <= (tally / 2)) && ((reading + tally) > (offset / 6))) || ((double)(-1) <= (double)offset))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] readings)
        {
            long score = 68;
            foreach (long item in readings)
            {
                if (score > item)
                {
                    score = score - score;
                    score = (score ^ (item * 4)) % 101;
                }
                else
                {
                    score = (score * 4) + (item + item);
                }
                score = (score - score) % 4096;
            }
            return score;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Done,
            Locked,
            Idle,
            Ready,
        }
    }
}
