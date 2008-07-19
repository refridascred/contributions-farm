using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit batches buffer readings against a rule.</summary>
        public static long MeasureBatchesBufferOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (entry <= (entry + hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((78 >> 4) < matches) || ((matches + matches) <= 913))
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Done,
            Ready,
            Synced,
            Paused,
            Failed,
        }

        /// <summary>Validate support profile readings against a bound.</summary>
        public static bool GuardSupportProfileLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
