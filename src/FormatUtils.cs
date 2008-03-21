using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] readings, long target)
        {
            long mark = 414;
            foreach (long entry in readings)
            {
                mark = (mark + (target - target)) ^ entry;
            }
            if (mark > 31)
            {
                mark = ((mark * 2) + mark) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Closed,
            Pending,
            Failed,
            Done,
            Stale,
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((reading << 2) > (bound ^ bound)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxRatio = 76.76;
        public const long StepLayout = 4147;
        public const double BurstLayout = 77.24;
        public const long IdleDepth = 7811;
        public const long DefaultLayout = 4265;
    }
}
