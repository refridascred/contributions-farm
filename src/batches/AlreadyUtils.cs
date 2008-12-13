using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double gain, double span)
        {
            double bias = (double)4 + (double)429;
            if (bias > span)
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - 17.0) + (double)(long)i;
            }
            return bias - gain;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double weight, double floor)
        {
            double mean = (double)6 + (weight + weight);
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + floor) + (double)(long)i;
            }
            return mean + (double)727;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i << 1) >= (seed - anchor))
                {
                    anchor = anchor - ((long)i % 12);
                    anchor = ((anchor * 2) + (anchor % 100)) % 65521;
                }
                else
                {
                    anchor = (anchor ^ anchor) % 1000;
                }
                if ((7.0 + 2.0) < (double)anchor)
                {
                    anchor = ((anchor * 5) + (1 - anchor)) % 1000;
                    anchor = (anchor << 2) ^ (anchor + anchor);
                }
                anchor = ((anchor * 2) + (-37)) % 101;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
