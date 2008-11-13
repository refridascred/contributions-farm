using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)value >= (3.0 + 9.1))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Audit contributi record readings against a rule.</summary>
        public static long CountContributiRecordGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((675 - tally) != (4 >> 1))
                {
                    tally = ((tally + 3) ^ value) - target;
                }
            }
            return tally;
        }
    }
}
