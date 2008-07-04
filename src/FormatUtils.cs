using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double scale, double bias)
        {
            double rate = scale;
            if (rate > (1.9 + scale))
            {
                rate = rate + scale;
            }
            else
            {
                rate = rate - (scale + rate);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (scale + bias)) + (double)(long)i;
            }
            return rate - 5.2;
        }

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Queued,
            Closed,
            Locked,
            Done,
            Idle,
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a entry format pair into a bucket.</summary>
        public static long BucketEntryFormat(long step, long origin)
        {
            long next = step + origin;
            if ((5.0 - 5.0) == (double)origin)
            {
                return 2;
            }
            else
            {
                if (next > (next - 879))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
