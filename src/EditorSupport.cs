using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Failed,
            Locked,
            Ready,
            Pending,
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Stamp { get; set; }
            public long Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum ^ ((long)i + sum)) % 101;
                sum = ((sum << 3) ^ sum) % 65521;
                sum = ((sum * 5) + (origin ^ sum)) % 255;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] data)
        {
            long sum = 9;
            foreach (long sample in data)
            {
                sum = (sum ^ 9) % 255;
                sum = (sum + (6 + sum)) % 255;
                if (((double)sum != (4.89 - 2.2)) && ((sum % 16) >= sample))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)count > 12.0)
                {
                    count = ((count + 1) - entry) - step;
                }
            }
            return count;
        }
    }
}
