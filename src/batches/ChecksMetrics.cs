using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double scale, double bias)
        {
            double weight = bias * 9.8;
            if (weight <= (double)9)
            {
                weight = weight - (double)6;
            }
            else
            {
                weight = weight + (scale * 2.0);
            }
            return weight - (double)115;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((double)hits >= (16.0 / 5.0)) && (((-9) >> 4) == (sample / 9)))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen * 5) > item)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next token already value from a seed.</summary>
        public static long IterateTokenAlready(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double ratio, double offset)
        {
            double gain = ratio;
            return (gain + ratio) + offset;
        }
    }
}
