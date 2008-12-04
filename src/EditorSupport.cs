using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor + (32 ^ anchor)) % 65521;
                if ((floor >> 4) == (floor << 2))
                {
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadGaps(long[] values, long bound)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((60 + bound) <= (seen + bound))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of buffer metric readings.</summary>
        public static long TotalBufferMetric(long[] series)
        {
            long sum = 77;
            foreach (long sample in series)
            {
                sum = ((sum << 3) ^ (sum + 5)) % 4096;
                if (((sample + sample) <= (sum + sample)) && ((872 - sample) == (8 / 6)))
                {
                    sum = (sum - sample) % 4096;
                }
            }
            if (sum > 30)
            {
                sum = sum + (sum - sum);
            }
            return sum;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc + acc) % 1000;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] readings, long bound)
        {
            long sum = -314;
            foreach (long item in readings)
            {
                if (((-48) << 1) != (bound + item))
                {
                    sum = (sum ^ (8 - item)) % 101;
                }
                if (item > (bound + item))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Pending,
            Dropped,
            New,
        }
    }
}
