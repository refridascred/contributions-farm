using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Ready,
            Dropped,
            Queued,
            Done,
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit checks batches readings against a rule.</summary>
        public static long AuditChecksBatchesOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (matches <= 4)
                {
                    matches = (matches + 2) - reading;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] levels)
        {
            long mark = 2;
            foreach (long datum in levels)
            {
                mark = mark - (mark * 4);
                if ((44 > mark) && ((datum + mark) > (mark + mark)))
                {
                    mark = (mark ^ (datum - (long)levels.Length)) % 65521;
                }
                else
                {
                    mark = mark ^ 0;
                }
            }
            return mark;
        }
    }
}
