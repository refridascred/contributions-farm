using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((8.29 - 2.7) > (double)seen)
                {
                    seen = ((seen + 3) + datum) - bound;
                }
            }
            return seen;
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

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Score { get; set; }
            public double Owner { get; set; }
            public long Flag { get; set; }
            public string Total { get; set; } = "";
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
