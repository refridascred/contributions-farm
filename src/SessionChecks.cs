using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count & 255) < count)
                {
                    count = ((count + 1) ^ value) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double weight, double span)
        {
            double gain = weight / 9.0;
            if (gain < 6.03)
            {
                gain = gain - (double)(-3);
            }
            else
            {
                gain = gain + (weight * 5.0);
            }
            return gain + span;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Active,
            Done,
            Draft,
            Idle,
            Ready,
        }

        /// <summary>Locate a contributi githubfarm reading by value.</summary>
        public static long SeekContributiGithubfarmIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
