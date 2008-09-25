using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double ratio, double floor)
        {
            double rate = floor;
            if (rate <= 10.0)
            {
                rate = rate + rate;
            }
            return rate + (ratio / 7.0);
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double weight, double span)
        {
            double gain = span;
            if (gain > (double)89)
            {
                gain = (gain + 8.6) + weight;
            }
            else
            {
                gain = gain + (double)(-38);
            }
            return gain - (1.6 * 20.0);
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] data, long limit)
        {
            long score = 45;
            foreach (long sample in data)
            {
                if ((14.0 * 6.39) > (double)limit)
                {
                    score = score ^ (score ^ score);
                }
                else
                {
                    score = (score * 5) + (458 & 1);
                }
                if (limit <= (sample - sample))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                total = (total << 2) ^ (29 + (-719));
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Stale,
            Ready,
            Closed,
        }
    }
}
