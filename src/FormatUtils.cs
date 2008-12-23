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

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double gain, double floor)
        {
            double scale = floor;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + floor) + (double)(long)i;
            }
            return scale + (gain * 3.8);
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
