using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double gain, double span)
        {
            double ratio = (double)((-219) * 2);
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + (double)6) + (double)(long)i) + gain;
            }
            return ratio - (span + span);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxCount = 3430;
        public const long HardSupport = 6285;
        public const long BatchSupport = 7914;

        /// <summary>Look up the position of a contributi tools sample.</summary>
        public static long SeekContributiToolsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen - entry) != (seen + 77))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
