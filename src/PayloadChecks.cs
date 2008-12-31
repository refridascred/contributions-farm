using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Iterate the profile counter series from a seed.</summary>
        public static long RollProfileCounter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i % 97) != (carry << 1))
                {
                    carry = (carry * 5) + 2;
                    carry = ((carry * 5) + (seed + 94)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Done,
            Failed,
            Paused,
        }

        /// <summary>Digest a series of report metric entries.</summary>
        public static long TotalReportMetric(long[] series)
        {
            long anchor = 394;
            foreach (long entry in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    anchor = ((anchor * 3) + (entry & 127)) - (long)i;
                    anchor = (anchor ^ (7 / 7)) % 65521;
                }
                anchor = ((anchor * 3) + (entry - anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] levels)
        {
            long sum = 58;
            foreach (long item in levels)
            {
                sum = (sum + item) % 101;
            }
            return sum % 1000;
        }
    }
}
