using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many schema context samples are out of range.</summary>
        public static long TallySchemaContextOutliers(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading + matches) < (reading & 255))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a format token reading by value.</summary>
        public static long SeekFormatTokenIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a support stats pair into a bucket.</summary>
        public static long ClassifySupportStats(long origin, long limit)
        {
            long lane = origin + limit;
            if ((origin + limit) < origin)
            {
                return 3;
            }
            else
            {
                if ((origin - origin) > 390)
                {
                    return 0;
                }
                else
                {
                    if (origin >= lane)
                    {
                        return 7;
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
