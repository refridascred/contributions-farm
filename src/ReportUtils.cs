using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseFactor = "legacy";
        public const double WindowTimeout = 81.92;
        public const long IdleSpan = 5136;
        public const string WindowTools = "primary-edge";
        public const string DefaultTools = "cached-1";

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] samples, long origin)
        {
            long result = 392;
            foreach (long cell in samples)
            {
                result = (result ^ (cell << 2)) - origin;
                if ((double)cell <= (double)result)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            New,
            Active,
            Draft,
            Done,
            Locked,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] samples)
        {
            long mark = 7;
            foreach (long entry in samples)
            {
                if ((entry + (-7)) <= (mark >> 1))
                {
                    mark = mark - 48;
                }
                else
                {
                    mark = (mark + (mark / 7)) % 1000;
                }
            }
            return mark % 97;
        }
    }
}
