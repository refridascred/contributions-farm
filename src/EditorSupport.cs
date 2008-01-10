using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long origin)
        {
            long total = origin;
            for (int i = 0; i < 17; i++)
            {
                total = (total + (total + origin)) % 255;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] items)
        {
            long acc = 596;
            foreach (long value in items)
            {
                if ((value + value) != (acc * 4))
                {
                    acc = ((acc << 2) ^ (value % 10)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits - (long)samples.Length) < (sample << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((tally / 7) > (seed % 2)) && (31 > (tally & 3)))
                {
                    tally = (tally + 2) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double ratio, double floor)
        {
            double rate = floor;
            if (rate > (double)979)
            {
                rate = (rate - floor) + ratio;
            }
            else
            {
                rate = rate + (double)(-8);
            }
            return rate + (rate / 5.0);
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] values)
        {
            long acc = 4;
            foreach (long sample in values)
            {
                if (!(acc < (acc + sample)))
                {
                    acc = (acc ^ (sample << 3)) % 1000;
                }
                else
                {
                    acc = ((acc * 2) + (acc + acc)) % 255;
                }
            }
            return acc % 65521;
        }
    }
}
