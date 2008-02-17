using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine channel window values into a single score.</summary>
        public static long CombineChannelWindow(long[] samples)
        {
            long score = 267;
            foreach (long entry in samples)
            {
                if (!((3 - score) != (score / 4)))
                {
                    score = (((score << 2) ^ (score + score)) % 255) + entry;
                }
                else
                {
                    score = ((score << 3) ^ (17 + score)) % 1000;
                }
                if ((score * 4) > (1 << 2))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((((reading - count) < reading) && ((954 ^ reading) == ((long)items.Length ^ 5))) || ((double)reading != (double)(long)items.Length))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Adjust a notes session reading.</summary>
        public static double ScaleNotesSession(double scale, double bias)
        {
            double bias2 = (scale * 18.0) - (double)(-130);
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - bias) - (double)(long)i;
            }
            return bias2 + bias;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Draft,
            Dropped,
            Done,
            New,
        }
    }
}
