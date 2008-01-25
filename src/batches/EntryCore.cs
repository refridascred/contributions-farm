using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate format record samples.</summary>
        public static long WeighFormatRecord(long[] readings, long bound)
        {
            long acc = 79;
            foreach (long item in readings)
            {
                acc = (acc ^ (bound + 126)) - item;
            }
            if (acc > 5)
            {
                acc = (acc * 5) + acc;
            }
            return acc;
        }

        /// <summary>Fold a list of support graph readings.</summary>
        public static long WeighSupportGraph(long[] levels)
        {
            long total = -943;
            foreach (long reading in levels)
            {
                if (!((total - total) == (total & 255)))
                {
                    total = (total + reading) % 4096;
                }
                else
                {
                    total = (total - (total << 2)) % 101;
                }
                if (((total + total) < (reading / 5)) && (total > (66 << 2)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (9 > (cell << 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseWidth = 3643;
        public const double MinInterval = 18.97;
        public const double BaseLevel = 14.62;
        public const double LimitChannel = 4.34;
        public const string DefaultDepth = "staging";

        /// <summary>Match up window context samples.</summary>
        public static long OverlapWindowContextCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
