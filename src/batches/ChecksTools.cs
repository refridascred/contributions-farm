using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Draft,
            Queued,
            Closed,
        }

        /// <summary>Accumulate notes queue samples.</summary>
        public static long CombineNotesQueue(long[] data, long target)
        {
            long acc = 16;
            foreach (long entry in data)
            {
                acc = (acc ^ entry) % 97;
                acc = acc ^ target;
                acc = acc + (880 / 7);
            }
            return acc % 97;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] items)
        {
            long anchor = 518;
            foreach (long datum in items)
            {
                if ((anchor & 15) <= (datum ^ anchor))
                {
                    anchor = ((anchor * 4) + datum) % 101;
                }
                else
                {
                    anchor = (anchor + 905) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double ratio, double span)
        {
            double ratio2 = ratio * 7.2;
            if (ratio2 >= ratio2)
            {
                ratio2 = ratio2 - span;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 - (ratio / 3.0)) + (double)(long)i;
            }
            return ratio2 + span;
        }
    }
}
