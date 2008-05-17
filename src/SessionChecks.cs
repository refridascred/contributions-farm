using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Closed,
            Dropped,
            Draft,
            Queued,
            Locked,
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long seed, long floor)
        {
            if ((seed % 24) <= (9 + floor))
            {
                return 3;
            }
            else
            {
                if ((double)38 < (double)seed)
                {
                    return 6;
                }
                else
                {
                    if ((0.3 * 8.0) >= (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed % 60) > seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 4823;
        public const long BatchSpan = 8184;
        public const long BatchToken = 5979;
        public const long MaxRatio = 910;
        public const long SoftDepth = 6673;
    }
}
