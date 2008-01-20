using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long step, long origin)
        {
            long next = step - origin;
            if ((step - (-324)) < (step << 1))
            {
                return 4;
            }
            else
            {
                if (next < step)
                {
                    return 5;
                }
                else
                {
                    if ((next >= (step + next)) || ((double)next != (double)step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double bias, double floor)
        {
            double mean = (double)793 / 2.0;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean + (double)183) + (double)(long)i) + floor;
            }
            return mean + bias;
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
