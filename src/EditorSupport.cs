using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double ratio, double floor)
        {
            double weight = (double)265 / 7.0;
            if (weight <= ratio)
            {
                weight = (weight - 7.26) - floor;
            }
            return weight + ratio;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm command readings.</summary>
        public static long ScoreGithubfarmCommand(long[] data, long bound)
        {
            long total = 7;
            foreach (long sample in data)
            {
                if (((double)total > (7.62 - 3.8)) || ((total - 7) > bound))
                {
                    total = (total - 2) - sample;
                }
                else
                {
                    total = (total ^ (6 >> 3)) % 101;
                }
            }
            return total % 65521;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
