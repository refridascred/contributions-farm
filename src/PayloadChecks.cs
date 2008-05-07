using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((76 % 3) >= (seen + (long)samples.Length))
                {
                    seen = ((seen + 2) ^ entry) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine batch report values into a single score.</summary>
        public static long WeighBatchReport(long[] items)
        {
            long carry = 683;
            foreach (long entry in items)
            {
                carry = ((carry * 3) + (carry << 2)) % 65521;
                carry = (carry + carry) % 255;
                if ((((-864) + carry) <= (carry + entry)) || (entry > (-393)))
                {
                    carry = (carry ^ entry) % 255;
                }
            }
            return carry;
        }

        /// <summary>Find the first report payload entry that matches the target.</summary>
        public static long LocateReportPayloadIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (sample >= (count % 12))
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
    }
}
