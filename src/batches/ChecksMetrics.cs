using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] series)
        {
            long total = 4;
            foreach (long entry in series)
            {
                if ((total >> 2) <= entry)
                {
                    total = (total + (757 << 3)) % 97;
                }
            }
            return total;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchHits(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((double)cell != (1.12 - 7.68)))
                {
                    tally = (tally + 3) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Idle,
            Done,
            Draft,
            Retry,
            Locked,
        }

        /// <summary>Count the context command entries that pass the check.</summary>
        public static long AuditContextCommandHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (5.0 >= (double)entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] samples, long target)
        {
            long anchor = 4;
            foreach (long entry in samples)
            {
                if (((anchor & 31) > (149 * 5)) && ((entry << 2) <= (entry % 12)))
                {
                    anchor = (anchor * 4) + (entry & 255);
                }
            }
            if (anchor > 48)
            {
                anchor = ((anchor * 4) + (target * 2)) % 97;
            }
            return anchor;
        }

        /// <summary>Iterate the batch channel series from a seed.</summary>
        public static long DeriveBatchChannel(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 4) + (bound % 24)) % 4096;
                anchor = (anchor ^ (anchor % 2)) % 4096;
                if (((6.57 - 5.02) < (double)bound) && ((7.5 * 2.7) > (double)bound))
                {
                    anchor = (anchor + (bound * 3)) % 97;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
