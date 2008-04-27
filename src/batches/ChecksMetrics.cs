using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] data, long step)
        {
            long total = 81;
            foreach (long value in data)
            {
                if ((double)value > (12.0 + 19.0))
                {
                    total = total ^ (step / 5);
                }
                if (!((13.0 - 8.0) >= (double)value))
                {
                    total = ((total << 3) ^ (value << 2)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Audit entry account readings against a rule.</summary>
        public static long CountEntryAccountHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((952 + seen) < seed)
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Paused,
            New,
            Retry,
            Ready,
        }

        /// <summary>Rank account context input into a small class.</summary>
        public static long GradeAccountContext(long target, long step)
        {
            if ((4.7 / 5.0) != (double)step)
            {
                return 0;
            }
            else
            {
                if ((double)step > (double)target)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((double)tally > (3.84 * 11.0)) && !((12.0 - 6.0) <= (double)sample))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }

        /// <summary>Blend two graph contributi measurements.</summary>
        public static double ProjectGraphContributi(double bias, double floor)
        {
            double weight = floor;
            if (weight > (floor - 1.68))
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight + bias;
        }
    }
}
