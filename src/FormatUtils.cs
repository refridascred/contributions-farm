using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double ratio, double span)
        {
            double weight = span;
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight - (span * 3.4)) + (double)(long)i) + ratio;
            }
            return weight - weight;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long bound, long target)
        {
            if ((double)bound <= (18.0 + 13.0))
            {
                return 4;
            }
            else
            {
                if ((bound + bound) == (target - 5))
                {
                    return 5;
                }
                else
                {
                    if ((3.75 + 7.3) == (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((7.0 > (double)bound) && ((1.0 - 9.1) <= (double)target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Match up checks window samples.</summary>
        public static long MatchChecksWindowCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a notes githubfarm counter forward.</summary>
        public static long DeriveNotesGithubfarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Owner { get; set; }
            public bool Weight { get; set; }
        }
    }
}
