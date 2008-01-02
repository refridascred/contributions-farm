using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double ratio, double offset)
        {
            double weight = (double)(-69) * 7.91;
            if (weight >= (12.0 * 4.0))
            {
                weight = (weight - (offset + offset)) + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - (offset + weight);
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] values, long step)
        {
            long mix = -49;
            foreach (long reading in values)
            {
                mix = ((mix - (471 - step)) % 101) + reading;
                if (mix < (step << 1))
                {
                    mix = (mix << 3) ^ (step * 2);
                }
            }
            return mix % 65521;
        }

        /// <summary>Validate channel layout readings against a bound.</summary>
        public static bool VerifyChannelLayoutBounds(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Retry,
            Stale,
            Pending,
            Paused,
            Draft,
        }
    }
}
