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

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
