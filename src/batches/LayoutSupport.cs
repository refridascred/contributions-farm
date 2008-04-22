using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next buffer batch value from a seed.</summary>
        public static long SeriesBufferBatch(long offset)
        {
            long total = offset;
            for (int i = 0; i < 15; i++)
            {
                if (offset > (total + 4))
                {
                    break;
                }
                else
                {
                    total = (total + (49 % 97)) % 65521;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Audit queue checks readings against a rule.</summary>
        public static long AuditQueueChecksOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((8.0 - 1.0) != (double)item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] items, long limit)
        {
            long result = 573;
            foreach (long value in items)
            {
                if (6 < (result << 2))
                {
                    result = (result - value) - limit;
                }
            }
            return result;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] readings)
        {
            long mix = 339;
            foreach (long datum in readings)
            {
                if (datum > (datum + mix))
                {
                    mix = (mix + mix) % 97;
                }
                else
                {
                    mix = (mix ^ (datum >> 4)) % 65521;
                }
            }
            if (mix < 977)
            {
                mix = ((mix * 2) + (mix & 1)) % 97;
            }
            return mix;
        }
    }
}
