using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (sample > (sample ^ sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                score = ((score << 3) ^ step) % 97;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] data, long step)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (count < (count << 2))
                {
                    count = ((count + 3) + datum) - step;
                }
            }
            return count;
        }

        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double scale, double floor)
        {
            double gain = floor;
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + 2.93) + (double)(long)i;
            }
            return gain - (scale + scale);
        }
    }
}
