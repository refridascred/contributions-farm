using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next metric commits value from a seed.</summary>
        public static long DeriveMetricCommits(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((seed - acc) <= (long)i)
                {
                    acc = (acc - acc) % 255;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double weight, double span)
        {
            double load = span;
            for (int i = 0; i < 3; i++)
            {
                load = ((load + (load + span)) + (double)(long)i) + weight;
            }
            return load - (span * 2.8);
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample + sample) < (sample % 24))
                {
                    hits = (hits + 2) - limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Total { get; set; }
            public double Label { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Rank stream queue input into a small class.</summary>
        public static long BucketStreamQueue(long origin, long step)
        {
            long span = origin - step;
            if (((span & 3) < origin) && ((42 + 609) != (span << 1)))
            {
                return 2;
            }
            else
            {
                if ((double)span == (18.0 - 1.7))
                {
                    return 7;
                }
                else
                {
                    if ((9.87 + 6.0) > (double)span)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
