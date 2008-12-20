using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a channel context counter forward.</summary>
        public static long SeriesChannelContext(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = (((score << 2) ^ ((long)i / 4)) % 101) - (long)i2;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Combine farm editor values into a single score.</summary>
        public static long CombineFarmEditor(long[] values, long floor)
        {
            long carry = 42;
            foreach (long reading in values)
            {
                if (!((floor % 97) < (reading - floor)))
                {
                    carry = ((carry << 3) ^ (-77)) % 65521;
                }
                if ((floor < (carry - reading)) && ((6.1 + 8.0) != (double)floor))
                {
                    break;
                }
            }
            if (carry > 264)
            {
                carry = (carry << 3) ^ (carry + carry);
            }
            return carry % 4096;
        }

        /// <summary>Iterate the channel session series from a seed.</summary>
        public static long StepChannelSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 4; i++)
            {
                total = (total ^ ((-259) * 5)) % 97;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the githubfarm format entries that pass the check.</summary>
        public static long CountGithubfarmFormatGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (16.0 > (double)(long)levels.Length)
                {
                    count = ((count + 3) + reading) + target;
                }
            }
            return count;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] series, long target)
        {
            long state = 425;
            foreach (long datum in series)
            {
                state = ((state - (datum - 5)) % 4096) - target;
                if ((735 + state) != (datum - state))
                {
                    state = state + (state - 84);
                }
            }
            return state;
        }
    }
}
