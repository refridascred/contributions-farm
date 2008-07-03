using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double scale, double span)
        {
            double mean = span + span;
            if (mean < mean)
            {
                mean = mean - (double)2;
            }
            else
            {
                mean = mean - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (scale + span)) + (double)(long)i;
            }
            return mean + (double)110;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)tally < (double)0)
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Draft,
            Paused,
            Ready,
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long floor, long seed)
        {
            long offset = floor ^ seed;
            if ((seed + floor) == (16 + 1))
            {
                return 3;
            }
            else
            {
                if (offset <= (offset * 3))
                {
                    return 7;
                }
                else
                {
                    if (!((seed % 97) < 555))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed >> 2) < (floor * 4))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
