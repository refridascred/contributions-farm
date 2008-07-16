using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample - count) != (count << 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of farm order readings.</summary>
        public static long DigestFarmOrder(long[] data, long limit)
        {
            long result = 934;
            foreach (long entry in data)
            {
                if (!((double)result >= 8.4))
                {
                    result = result + 9;
                    break;
                }
                if ((double)entry >= (6.77 * 17.0))
                {
                    result = result + (entry - 7);
                }
                else
                {
                    result = ((result << 2) ^ limit) % 1000;
                }
            }
            return result;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Level { get; set; }
            public long Owner { get; set; }
            public bool Count { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Check that every session profile entry stays within the limit.</summary>
        public static bool VerifySessionProfileRange(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!((6.59 * 3.45) < (double)8))
                {
                    count = (count + 3) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
