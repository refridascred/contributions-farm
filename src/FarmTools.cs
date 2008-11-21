using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Stale,
            Closed,
            Idle,
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double weight, double floor)
        {
            double gain = weight + floor;
            return gain + floor;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((long)levels.Length >> 1) == (count * 5))
                {
                    count = (count + 3) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
