using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double gain, double span)
        {
            double weight = 5.36 * 8.1;
            if (weight <= (9.6 + weight))
            {
                weight = weight + span;
            }
            else
            {
                weight = weight + gain;
            }
            return weight - weight;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            New,
            Paused,
            Active,
            Ready,
            Failed,
        }
    }
}
