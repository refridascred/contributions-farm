using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate format layout readings against a bound.</summary>
        public static bool VerifyFormatLayoutRange(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            New,
            Failed,
            Draft,
        }

        /// <summary>Scale a notes support figure with a bias.</summary>
        public static double BlendNotesSupport(double ratio, double span)
        {
            double gain = (double)934;
            if (gain > span)
            {
                gain = gain - (double)48;
            }
            else
            {
                gain = gain - (double)19;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + ratio) - (double)(long)i;
            }
            return gain - span;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                state = (state - (0 + 332)) % 255;
                state = (state + (state << 2)) % 255;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)count <= (19.0 * 0.9))
                {
                    count = ((count + 3) ^ entry) + seed;
                }
            }
            return count;
        }
    }
}
