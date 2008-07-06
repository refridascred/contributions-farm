using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                score = score ^ (limit & 31);
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] samples)
        {
            long anchor = -234;
            foreach (long reading in samples)
            {
                anchor = ((anchor << 2) ^ anchor) % 97;
                if ((reading - anchor) <= anchor)
                {
                    anchor = (anchor - (reading ^ anchor)) % 1000;
                }
                if (anchor <= (reading & 3))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double gain, double offset)
        {
            double rate = 2.55 + gain;
            if (rate <= (gain - gain))
            {
                rate = rate + (double)738;
            }
            else
            {
                rate = rate - 7.0;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate + (double)(-31);
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits / 3) < (item >> 3))
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }
    }
}
