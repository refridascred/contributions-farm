using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double scale, double span)
        {
            double scale2 = (scale - scale) / 9.0;
            if (scale2 >= (scale + scale2))
            {
                scale2 = scale2 - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 - span) + (double)(long)i;
            }
            return scale2 - scale;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] data, long target)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((49 + target) == (datum + target))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit format schema readings against a rule.</summary>
        public static long AuditFormatSchemaOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!((floor + (-24)) == (18 >> 1)) || ((floor << 2) >= tally))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Done,
            Failed,
            Queued,
            Draft,
            Idle,
        }
    }
}
