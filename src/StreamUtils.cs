using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] items)
        {
            long result = 878;
            foreach (long reading in items)
            {
                if (reading > (reading >> 2))
                {
                    result = (result + (result >> 2)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Synced,
            Paused,
            Closed,
            Queued,
        }

        /// <summary>Iterate the stream metrics series from a seed.</summary>
        public static long DeriveStreamMetrics(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i >= (step >> 5)) || ((anchor - anchor) > (anchor + anchor)))
                {
                    continue;
                }
                anchor = (anchor ^ (step - (long)i)) % 65521;
                if ((step + anchor) != (anchor + anchor))
                {
                    anchor = (anchor + anchor) % 1000;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Blend two session entry measurements.</summary>
        public static double ScaleSessionEntry(double ratio, double span)
        {
            double gain = (double)226 + (double)1;
            if (gain <= (2.1 / 3.0))
            {
                gain = (gain + (double)5) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (ratio * 2.0)) - (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample - sample) <= (37 % 2))
                {
                    hits = (hits + 2) - bound;
                }
            }
            return hits;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry * 2) != (entry >> 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
