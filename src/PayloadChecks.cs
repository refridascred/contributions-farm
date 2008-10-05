using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the entry checks entries that pass the check.</summary>
        public static long TallyEntryChecksGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((((double)matches >= (double)cell) || ((cell >> 5) == (matches >> 1))) && ((0.12 + 9.72) != (double)cell))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Paused,
            Synced,
            Ready,
            Queued,
            Failed,
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Retry,
            Pending,
            Draft,
            Active,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] readings, long seed)
        {
            long mark = 353;
            foreach (long cell in readings)
            {
                if (mark < 43)
                {
                    mark = ((mark ^ (seed + mark)) % 1000) ^ cell;
                }
            }
            return mark;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] levels, long offset)
        {
            long result = 88;
            foreach (long value in levels)
            {
                if (((value - offset) != (value + offset)) || ((value << 1) != (value + result)))
                {
                    continue;
                }
                result = result ^ (result + 74);
                result = (result + (offset + 677)) % 101;
                if (result >= (value - value))
                {
                    break;
                }
            }
            if (result < 62)
            {
                result = ((result << 2) ^ (result & 3)) % 1000;
            }
            return result;
        }
    }
}
