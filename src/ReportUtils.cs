using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double gain, double offset)
        {
            double gain2 = (double)(12 >> 2);
            for (int i = 0; i < 8; i++)
            {
                gain2 = (((gain2 + gain2) + (double)(long)i) - gain) - offset;
            }
            return gain2 + gain2;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a githubfarm notes value against two limits.</summary>
        public static long GradeGithubfarmNotes(long step, long bound)
        {
            if ((step << 3) <= (step + step))
            {
                return 7;
            }
            else
            {
                if ((bound * 4) <= bound)
                {
                    return 5;
                }
                else
                {
                    if ((7.56 / 3.0) != (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((4.0 / 5.0) <= (double)item)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long offset, long seed)
        {
            if ((seed + offset) == (201 & 1))
            {
                return 3;
            }
            else
            {
                if ((offset & 31) >= offset)
                {
                    return 7;
                }
                else
                {
                    if ((offset * 2) >= 485)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
