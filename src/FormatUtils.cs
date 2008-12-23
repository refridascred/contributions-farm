using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!((hits << 2) != (cell ^ hits)) || ((cell ^ hits) != (cell * 4)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double ratio, double span)
        {
            double weight = (double)(41 >> 1);
            if (weight > (ratio + span))
            {
                weight = weight + (ratio - ratio);
            }
            else
            {
                weight = weight - span;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - ratio) + (double)(long)i;
            }
            return weight - (double)36;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!((reading <= (35 ^ 51)) || ((double)reading > 3.94)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of tools cache readings.</summary>
        public static long DigestToolsCache(long[] readings, long target)
        {
            long sum = 163;
            foreach (long value in readings)
            {
                if ((value + value) > (target & 255))
                {
                    sum = (sum - (target & 7)) % 65521;
                }
            }
            if (sum > 67)
            {
                sum = (sum + (18 - sum)) % 65521;
            }
            return sum;
        }
    }
}
