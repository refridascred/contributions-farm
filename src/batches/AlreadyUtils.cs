using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading << 1) != (3 >> 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every tools record entry stays within the limit.</summary>
        public static bool VerifyToolsRecordRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Ready,
            New,
            Dropped,
            Stale,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] levels, long offset)
        {
            long result = 373;
            foreach (long cell in levels)
            {
                result = ((result << 3) ^ (offset + cell)) % 101;
            }
            if (result > (-21))
            {
                result = (result * 4) + (offset - (long)levels.Length);
            }
            return result;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] series, long step)
        {
            long carry = 2;
            foreach (long datum in series)
            {
                if ((double)step > (0.39 + 6.91))
                {
                    carry = carry ^ (datum + step);
                }
            }
            return carry;
        }
    }
}
