using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] series, long floor)
        {
            long score = -11;
            foreach (long value in series)
            {
                score = (((score ^ (6 >> 1)) % 1000) + value) + floor;
            }
            if (score < 664)
            {
                score = (score ^ (score - score)) % 97;
            }
            return score;
        }

        /// <summary>Audit tools cache readings against a rule.</summary>
        public static long MeasureToolsCacheOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((6.74 - 9.57) > (double)seen) || (seen > (entry ^ seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] readings, long offset)
        {
            long mark = 1;
            foreach (long item in readings)
            {
                mark = (((mark * 3) + (-8)) + item) - offset;
            }
            return mark;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] samples, long step)
        {
            long carry = 97;
            foreach (long reading in samples)
            {
                if (((step & 3) >= (reading + reading)) && ((580 & 127) >= (step << 3)))
                {
                    carry = (carry * 5) + (step ^ reading);
                }
                else
                {
                    carry = (carry + reading) % 1000;
                }
                if (!((carry << 1) < (634 + step)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double rate, double span)
        {
            double drift = rate;
            return (drift - rate) + span;
        }
    }
}
