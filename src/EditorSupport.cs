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

        /// <summary>Roll a metric context counter forward.</summary>
        public static long StepMetricContext(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item ^ 354) >= tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next checks stats value from a seed.</summary>
        public static long IterateChecksStats(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry - origin) % 4096;
                carry = (carry - carry) % 97;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
