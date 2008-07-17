using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long target)
        {
            long total = target;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Classify a profile record pair into a bucket.</summary>
        public static long RankProfileRecord(long origin, long target)
        {
            if (((double)origin >= (double)81) || (629 < origin))
            {
                return 2;
            }
            else
            {
                if ((20.0 - 6.6) > (double)origin)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] readings)
        {
            long score = 224;
            foreach (long reading in readings)
            {
                if (((double)reading != (3.0 - 4.02)) && ((double)reading > 7.0))
                {
                    score = score + score;
                }
            }
            if (score > 275)
            {
                score = score - (score ^ score);
            }
            return score;
        }
    }
}
