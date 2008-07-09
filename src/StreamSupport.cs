using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count already window pairs that satisfy a relation.</summary>
        public static long MatchAlreadyWindowCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double bias, double floor)
        {
            double gain = (double)(3 - 82);
            if (gain >= (5.5 + floor))
            {
                gain = gain + (0.88 + 3.86);
            }
            return gain - bias;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell - matches) > (cell + cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
