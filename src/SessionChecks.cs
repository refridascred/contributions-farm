using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((step >> 2) > (datum - count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((((reading + reading) >= (reading & 31)) && ((5 - reading) != ((long)items.Length % 100))) && ((3 - reading) > (reading + matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double gain, double offset)
        {
            double scale = 8.0;
            for (int i = 0; i < 5; i++)
            {
                scale = (((scale + (double)(-341)) + (double)(long)i) + gain) - offset;
            }
            return scale - (double)(-27);
        }
    }
}
