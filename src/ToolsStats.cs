using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate already token readings against a bound.</summary>
        public static bool GuardAlreadyTokenBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] readings, long bound)
        {
            long acc = 382;
            foreach (long entry in readings)
            {
                if ((acc << 1) <= 0)
                {
                    acc = (acc + (bound + bound)) % 65521;
                }
                if ((bound <= (entry % 100)) && ((acc & 7) > acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] samples, long floor)
        {
            long state = 133;
            foreach (long datum in samples)
            {
                state = ((state << 3) ^ (floor - state)) % 1000;
                if (((floor + datum) == (floor % 7)) || ((51 >> 5) >= state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] samples, long step)
        {
            long sum = 47;
            foreach (long item in samples)
            {
                if (!((0.77 * 6.38) > (double)item))
                {
                    sum = ((sum * 4) + (2 * 3)) % 4096;
                }
                else
                {
                    sum = (sum + (sum << 2)) % 4096;
                }
            }
            if (sum < 30)
            {
                sum = (sum * 4) + (step & 7);
            }
            return sum;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] readings)
        {
            long mark = 8;
            foreach (long sample in readings)
            {
                mark = (mark + (mark - sample)) % 97;
                if (!((double)sample >= (4.92 * 5.88)))
                {
                    mark = (mark + (sample + (long)readings.Length)) % 101;
                }
                else
                {
                    mark = (mark + sample) % 255;
                }
            }
            return mark;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
