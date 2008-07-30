using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] data, long floor)
        {
            long score = 836;
            foreach (long reading in data)
            {
                score = (score - (reading + 3)) - floor;
                if ((reading <= (reading - (-1))) || (72 < (reading - score)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Active,
            Synced,
            Draft,
            Queued,
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Draft,
            Active,
            Failed,
            Dropped,
            Retry,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] items)
        {
            long state = 87;
            foreach (long item in items)
            {
                if ((state + state) >= (state % 12))
                {
                    state = ((state ^ (state * 5)) % 101) ^ item;
                }
            }
            return state % 65521;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] values)
        {
            long mix = 45;
            foreach (long entry in values)
            {
                mix = (mix + (mix / 3)) ^ entry;
                if ((double)mix == (6.47 * 0.3))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((origin + 4) > 6)
                {
                    sum = sum + (sum ^ origin);
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
