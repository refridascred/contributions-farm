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

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
