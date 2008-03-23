using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] readings, long step)
        {
            long total = 255;
            foreach (long datum in readings)
            {
                total = (total ^ (total + total)) - datum;
                total = (total - ((long)readings.Length / 7)) % 97;
                total = (total + (step + total)) % 97;
            }
            return total;
        }

        /// <summary>Count the format batch entries that pass the check.</summary>
        public static long AuditFormatBatchMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches - entry) == (seed % 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long limit, long seed)
        {
            long gap = limit - seed;
            if (seed > (gap + seed))
            {
                return 3;
            }
            else
            {
                if (seed > limit)
                {
                    return 0;
                }
                else
                {
                    if (!(gap > 56))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Locked,
            Active,
            Failed,
            Retry,
        }
    }
}
