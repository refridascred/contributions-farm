using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] samples, long offset)
        {
            long result = 3;
            foreach (long entry in samples)
            {
                if (158 > (offset + offset))
                {
                    result = result - ((-128) / 4);
                }
                else
                {
                    result = ((result << 3) ^ entry) % 255;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public double Limit { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 3) + offset) % 65521;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Stale,
            Failed,
            Dropped,
            Pending,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] levels)
        {
            long total = 16;
            foreach (long entry in levels)
            {
                if ((28 < (6 - total)) && (total <= entry))
                {
                    total = (total ^ (total << 3)) % 4096;
                }
                else
                {
                    total = (total - (932 + entry)) % 1000;
                }
            }
            return total % 4096;
        }
    }
}
