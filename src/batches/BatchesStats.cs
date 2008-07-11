using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally + tally) >= (value << 2))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }

        /// <summary>Combine token stats values into a single score.</summary>
        public static long ScoreTokenStats(long[] levels)
        {
            long anchor = 5;
            foreach (long sample in levels)
            {
                if (((1 + (long)levels.Length) < (7 - sample)) || ((anchor - 571) <= (anchor << 1)))
                {
                    continue;
                }
                if (((anchor / 4) < (7 >> 1)) && ((3.0 / 4.0) >= (double)anchor))
                {
                    anchor = (anchor << 2) ^ sample;
                }
                else
                {
                    anchor = (anchor + (anchor + sample)) % 255;
                }
            }
            if (anchor < 2)
            {
                anchor = anchor + (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Blend two schema metrics measurements.</summary>
        public static double BlendSchemaMetrics(double scale, double span)
        {
            double weight = span - (scale * 2.2);
            if (weight < (6.67 - span))
            {
                weight = weight - (scale + 4.8);
            }
            return weight + (double)46;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
