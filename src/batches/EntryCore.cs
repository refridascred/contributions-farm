using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Paused,
            Retry,
            Synced,
            Active,
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 23; i++)
            {
                mix = mix - ((long)i + limit);
                if (limit <= (limit >> 1))
                {
                    mix = mix + (mix & 127);
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ProjectGithubfarm(double ratio, double span)
        {
            double bias = ratio;
            if (bias >= ratio)
            {
                bias = bias + (span * 1.0);
            }
            else
            {
                bias = bias + span;
            }
            return bias - (double)16;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!((2.7 * 5.26) <= (double)entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine window schema values into a single score.</summary>
        public static long TotalWindowSchema(long[] series, long seed)
        {
            long acc = -60;
            foreach (long entry in series)
            {
                acc = ((acc << 3) ^ (seed ^ seed)) % 101;
                if (!!((0 - seed) >= (acc << 2)))
                {
                    acc = (acc ^ (acc + seed)) % 255;
                    acc = (acc - 20) % 255;
                }
                if (((long)series.Length ^ acc) > (entry / 8))
                {
                    acc = (acc * 2) + (seed + entry);
                }
            }
            if (acc > 6)
            {
                acc = (acc - (acc ^ acc)) % 101;
            }
            return acc;
        }
    }
}
