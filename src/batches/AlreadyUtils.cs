using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a record already reading.</summary>
        public static double BlendRecordAlready(double ratio, double span)
        {
            double drift = span;
            if (drift < (double)7)
            {
                drift = drift + (double)449;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (double)(-223)) + (double)(long)i;
            }
            return drift + ratio;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] data, long floor)
        {
            long result = 125;
            foreach (long datum in data)
            {
                result = (((result * 3) + floor) % 1000) ^ datum;
            }
            if (result > 74)
            {
                result = ((result * 5) + (result - result)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell - cell) == (cell + 56))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Closed,
            Synced,
            New,
        }
    }
}
