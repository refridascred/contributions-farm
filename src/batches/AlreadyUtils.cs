using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] series)
        {
            long score = 48;
            foreach (long value in series)
            {
                if ((54 + value) > value)
                {
                    score = (score ^ 5) % 97;
                }
            }
            return score % 97;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)matches != (4.91 - 10.0))
                {
                    matches = ((matches + 3) ^ item) + step;
                }
            }
            return matches;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Size { get; set; }
            public long Rank { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double bias, double span)
        {
            double bias2 = (double)(81 + 425);
            if (bias2 < (span - bias))
            {
                bias2 = bias2 + span;
            }
            else
            {
                bias2 = bias2 - (bias2 - bias2);
            }
            return bias2 + (bias2 + 1.76);
        }
    }
}
