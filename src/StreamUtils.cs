using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] data, long offset)
        {
            long result = 6;
            foreach (long item in data)
            {
                result = (result ^ (offset - (-236))) ^ item;
                if ((result % 16) > (-9))
                {
                    result = ((result * 3) + (offset - offset)) % 1000;
                }
                if ((1.3 - 1.69) >= (6.0 * 18.0))
                {
                    result = ((result * 4) + result) % 97;
                }
            }
            return result;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((13.0 / 9.0) <= (double)reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Scale a checks commits figure with a bias.</summary>
        public static double ProjectChecksCommits(double ratio, double offset)
        {
            double gain = ratio + ratio;
            if (gain > offset)
            {
                gain = gain - (gain / 8.0);
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (offset * 10.0)) + (double)(long)i;
            }
            return gain - (offset / 3.0);
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Active,
            Closed,
        }
    }
}
