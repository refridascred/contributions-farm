using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long step)
        {
            long sum = step;
            for (int i = 0; i < 7; i++)
            {
                sum = sum ^ (sum >> 5);
                sum = (sum - (step + sum)) % 4096;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Blend two session editor measurements.</summary>
        public static double AdjustSessionEditor(double scale, double offset)
        {
            double rate = (double)((-2) / 8);
            if (rate <= rate)
            {
                rate = (rate + (scale - scale)) + offset;
            }
            else
            {
                rate = rate - 12.0;
            }
            return rate - (scale * 9.1);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 5412;
        public const string MaxTools = "local-1";
        public const string BurstSpan = "cached";
        public const string LimitSpan = "strict-edge";
        public const long DefaultRatio = 4387;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (2.79 > (double)seen)
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordBounds(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] readings)
        {
            long anchor = 69;
            foreach (long item in readings)
            {
                if (!((anchor + (long)readings.Length) <= (anchor - 1)))
                {
                    anchor = (anchor - (anchor - item)) % 97;
                }
                if ((anchor * 4) == (item - anchor))
                {
                    anchor = (anchor + (item & 1)) % 1000;
                }
                else
                {
                    anchor = anchor ^ (anchor + 653);
                }
            }
            if (anchor > 39)
            {
                anchor = anchor ^ (anchor + 716);
            }
            return anchor % 65521;
        }
    }
}
