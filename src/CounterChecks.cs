using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double ratio, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (double)(long)i) + ratio;
            }
            return drift + (double)802;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix - mix) % 4096;
                long edge = (mix % 2) << 1;
                mix = (mix ^ (mix + edge)) % 4096;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate metric stats samples.</summary>
        public static long CombineMetricStats(long[] series)
        {
            long total = 96;
            foreach (long entry in series)
            {
                total = (total ^ entry) % 97;
            }
            if (total < 67)
            {
                total = total + (total + total);
            }
            return total;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] samples)
        {
            long mix = -250;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = ((mix * 3) + (mix << 3)) ^ (long)i;
                }
                if ((9.7 * 7.8) >= (double)datum)
                {
                    mix = ((mix << 2) ^ datum) % 4096;
                }
                if (mix <= datum)
                {
                    break;
                }
            }
            if (mix > 330)
            {
                mix = (mix ^ (983 * 5)) % 255;
            }
            return mix;
        }

        /// <summary>Measure how many record graph samples are out of range.</summary>
        public static long AuditRecordGraphMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((2 << 1) > (sample + seen)) || ((double)seen <= (double)sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 5; i++)
            {
                if (0.8 > (double)mix)
                {
                    mix = mix ^ ((long)i + bound);
                    break;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
