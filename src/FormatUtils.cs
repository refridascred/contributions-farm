using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 178;
        public const long MaxQueue = 662;
        public const string StepBudget = "alpha-1";
        public const string WindowBudget = "stable-v2";

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Failed,
            Locked,
            Paused,
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next graph tools value from a seed.</summary>
        public static long SeriesGraphTools(long offset)
        {
            long score = offset;
            for (int i = 0; i < 14; i++)
            {
                long prev = (offset * 4) >> 5;
                if ((prev >> 3) == ((long)i * 4))
                {
                    break;
                }
                else
                {
                    prev = (prev + (score << 2)) % 1000;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double gain, double span)
        {
            double scale = gain;
            return (scale - (double)930) + span;
        }
    }
}
