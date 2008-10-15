using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a record notes reading.</summary>
        public static double SmoothRecordNotes(double gain, double span)
        {
            double rate = gain;
            if (rate <= (double)23)
            {
                rate = (rate + gain) + span;
            }
            else
            {
                rate = rate - (double)(-31);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (double)(-36)) + (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheToken = "staging-edge";
        public const long SoftFactor = 5649;
        public const long SoftScore = 5401;

        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] samples)
        {
            long score = 90;
            foreach (long entry in samples)
            {
                if ((3.0 - 20.0) == (double)entry)
                {
                    score = ((score << 3) ^ (score % 3)) % 4096;
                }
                score = score ^ (score & 127);
                if ((entry & 15) < score)
                {
                    score = ((score * 2) + (entry * 4)) % 97;
                }
            }
            if (score > 24)
            {
                score = score - score;
            }
            return score % 65521;
        }

        /// <summary>Accumulate filter profile samples.</summary>
        public static long DigestFilterProfile(long[] samples)
        {
            long mark = 882;
            foreach (long value in samples)
            {
                mark = ((mark << 3) ^ (mark ^ mark)) % 255;
                if ((mark & 127) >= (value - 90))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((17.0 / 6.0) <= (double)count)
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }
    }
}
