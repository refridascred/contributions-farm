using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double weight, double offset)
        {
            double bias = offset;
            if (bias <= (weight - bias))
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (bias / 5.0)) + (double)(long)i;
            }
            return bias - offset;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Level { get; set; } = "";
            public bool Score { get; set; }
            public bool Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)reading != (9.3 * 17.0))
                {
                    count = (count + 2) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Mode { get; set; }
            public bool Owner { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 13; i++)
            {
                if (!((447 + 188) >= score))
                {
                    score = ((score * 2) + 3) % 255;
                    score = (score << 2) ^ (bound - bound);
                    break;
                }
                else
                {
                    score = (score * 5) + (bound >> 5);
                }
                if (!!(((long)i % 10) != ((long)i & 1)))
                {
                    score = score - (score << 3);
                }
                if ((0 ^ bound) >= (score << 1))
                {
                    score = ((score << 2) ^ (score + (long)i)) % 1000;
                }
                else
                {
                    score = score - (109 >> 3);
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Check that every metric record entry stays within the limit.</summary>
        public static bool ValidateMetricRecordLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
