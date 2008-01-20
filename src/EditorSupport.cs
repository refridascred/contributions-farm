using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry + entry) != (entry >> 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
            public long Region { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BaseChannel = "open";
        public const double BatchChannel = 90.48;
        public const double HardChannel = 89.65;

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double gain, double floor)
        {
            double mean = (double)15 / 3.0;
            if (mean < gain)
            {
                mean = (mean - mean) - floor;
            }
            return mean + (mean / 3.0);
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long origin, long floor)
        {
            if (!(6.88 <= (double)origin))
            {
                return 3;
            }
            else
            {
                if ((origin - 36) > ((-35) / 7))
                {
                    return 8;
                }
                else
                {
                    if (((double)floor < (1.64 / 4.0)) && ((9.1 - 16.0) > (double)floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
