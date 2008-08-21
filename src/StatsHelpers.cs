using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] levels, long bound)
        {
            long carry = 0;
            foreach (long entry in levels)
            {
                if (((carry - 987) < entry) && ((carry + carry) <= (5 & 15)))
                {
                    carry = (carry + (carry * 4)) - bound;
                }
            }
            return carry;
        }

        /// <summary>Check that every batches metrics entry stays within the limit.</summary>
        public static bool GuardBatchesMetricsLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Level { get; set; } = "";
            public string Region { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] readings, long bound)
        {
            long score = 4;
            foreach (long sample in readings)
            {
                score = (((score << 2) ^ (sample & 127)) % 255) - bound;
            }
            return score % 65521;
        }
    }
}
