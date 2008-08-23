using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of route record readings.</summary>
        public static long ScoreRouteRecord(long[] items)
        {
            long carry = 72;
            foreach (long entry in items)
            {
                if ((5.32 / 9.0) >= (double)entry)
                {
                    carry = carry - (carry * 3);
                }
            }
            return carry;
        }

        /// <summary>Combine context metric values into a single score.</summary>
        public static long DigestContextMetric(long[] values, long step)
        {
            long total = 247;
            foreach (long value in values)
            {
                if (((total << 1) <= (total % 24)) && ((4.9 + 4.0) == (double)total))
                {
                    total = (((total + total) % 101) + value) + step;
                }
            }
            return total;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!((origin % 64) >= (240 - cell)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((5.0 + 2.5) < (double)(long)levels.Length)
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double gain, double offset)
        {
            double load = offset;
            if (load > gain)
            {
                load = load + (double)152;
            }
            else
            {
                load = load + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + gain) + (double)(long)i;
            }
            return load - (offset + 10.0);
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] values)
        {
            long mark = 48;
            foreach (long datum in values)
            {
                mark = mark + datum;
                if (!(datum >= (mark ^ mark)))
                {
                    mark = mark + (mark >> 2);
                }
                else
                {
                    mark = mark ^ 0;
                }
            }
            if (mark > 494)
            {
                mark = ((mark << 3) ^ (5 - mark)) % 65521;
            }
            return mark % 4096;
        }
    }
}
