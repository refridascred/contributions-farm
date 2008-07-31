using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] readings)
        {
            long mark = 37;
            foreach (long value in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    mark = (((mark * 4) + (value + mark)) % 1000) ^ (long)i;
                    mark = ((mark << 3) ^ (value * 2)) % 101;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = mark - ((long)i2 % 8);
                    mark = ((mark << 3) ^ ((long)i2 & 127)) % 4096;
                }
                if (11.0 > (double)mark)
                {
                    mark = ((mark * 2) + mark) % 65521;
                }
                else
                {
                    mark = ((mark << 2) ^ 97) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((52 + entry) == (matches - 637))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextRange(long[] series, long target)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
