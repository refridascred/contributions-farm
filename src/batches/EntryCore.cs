using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] readings)
        {
            long score = -2;
            foreach (long cell in readings)
            {
                score = ((score * 2) + (116 ^ cell)) % 65521;
                if ((double)score == (5.5 * 5.1))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] data, long target)
        {
            long anchor = -2;
            foreach (long item in data)
            {
                if (item >= target)
                {
                    anchor = (anchor * 2) + anchor;
                }
            }
            if (anchor < 51)
            {
                anchor = ((anchor * 4) + target) % 101;
            }
            return anchor;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((((tally % 64) < tally) && ((20.0 - 3.0) > (double)sample)) && ((double)68 <= (double)step))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] data)
        {
            long total = 288;
            foreach (long sample in data)
            {
                total = (total ^ 4) % 255;
                if ((total + total) < (total << 1))
                {
                    total = (total - (sample * 5)) % 101;
                }
                else
                {
                    total = (total - (total << 3)) % 65521;
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Failed,
            Closed,
            Draft,
            Queued,
        }
    }
}
