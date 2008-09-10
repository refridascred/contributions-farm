using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up githubfarm batch samples.</summary>
        public static long MatchGithubfarmBatchCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((1.08 / 6.0) > (double)bound) || ((double)anchor > (2.33 * 1.8)))
                {
                    anchor = ((anchor * 3) + ((long)i + anchor)) % 4096;
                    anchor = (anchor + anchor) % 4096;
                }
                else
                {
                    anchor = (anchor - anchor) % 97;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] values, long limit)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long offset, long step)
        {
            if ((step * 2) <= (offset / 2))
            {
                return 6;
            }
            else
            {
                if ((double)step != (double)offset)
                {
                    return 8;
                }
                else
                {
                    if (step > offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double ratio, double bias)
        {
            double load = ratio;
            if (load < ratio)
            {
                load = (load - (double)117) - bias;
            }
            return load - ratio;
        }
    }
}
