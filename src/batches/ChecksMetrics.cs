using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] readings)
        {
            long mark = -6;
            foreach (long entry in readings)
            {
                mark = (mark - (265 >> 1)) % 4096;
                if ((mark + entry) >= (mark >> 3))
                {
                    mark = mark + (entry - mark);
                }
            }
            return mark;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            New,
            Pending,
            Draft,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry + matches) <= (matches & 127))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit batch format readings against a rule.</summary>
        public static long CountBatchFormatGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((offset * 4) >= seen)
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }
    }
}
