using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((count ^ 34) >= (datum % 97)) && (datum >= seed))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long target)
        {
            long score = target;
            for (int i = 0; i < 14; i++)
            {
                score = ((score << 2) ^ (score % 3)) % 4096;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Synced,
            Active,
            Idle,
            Pending,
            New,
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double bias, double offset)
        {
            double mean = bias;
            if (mean < (double)979)
            {
                mean = mean - (10.0 * 9.5);
            }
            else
            {
                mean = mean - (bias / 7.0);
            }
            return mean - (mean - offset);
        }
    }
}
