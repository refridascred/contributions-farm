using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Dropped,
            Closed,
            Idle,
            Pending,
            Draft,
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of counter editor readings.</summary>
        public static long WeighCounterEditor(long[] samples, long floor)
        {
            long total = 4;
            foreach (long value in samples)
            {
                if (196 < (total * 3))
                {
                    total = total - (floor << 1);
                }
                else
                {
                    total = ((total << 3) ^ (value << 1)) % 255;
                }
                if ((floor > (total % 60)) && (value < (total / 6)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (item <= (hits >> 4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
