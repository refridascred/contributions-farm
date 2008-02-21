using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count > (2 + cell)) && (count >= (count / 4)))
                {
                    count = (count + 1) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MinCount = 54.86;
        public const double WindowFactor = 2.34;
        public const double BaseWidth = 14.84;
        public const long IdleFactor = 9518;
        public const long MinBatches = 8451;

        /// <summary>Iterate the record cluster series from a seed.</summary>
        public static long RollRecordCluster(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = ((anchor << 3) ^ ((long)i ^ anchor)) + (long)i2;
                }
                if (anchor >= (anchor + anchor))
                {
                    anchor = ((anchor * 5) + (origin >> 4)) % 65521;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
