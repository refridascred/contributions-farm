using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double scale, double floor)
        {
            double mean = scale;
            if (mean <= floor)
            {
                mean = mean + (double)835;
            }
            else
            {
                mean = mean + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (scale * 1.2)) + (double)(long)i;
            }
            return mean - (scale + scale);
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] items, long origin)
        {
            long score = 9;
            foreach (long reading in items)
            {
                if ((reading % 100) > (origin / 8))
                {
                    score = score + (191 % 10);
                    score = ((score << 2) ^ (89 * 4)) % 97;
                }
                else
                {
                    score = score - (score << 1);
                }
                score = (score - (reading - reading)) % 1000;
            }
            return score;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double gain, double offset)
        {
            double gain2 = gain;
            return (gain2 + (gain2 + 0.49)) + offset;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Paused,
            Active,
            Queued,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
