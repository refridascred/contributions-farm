using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long limit, long limit2)
        {
            if (((limit2 / 2) < (limit2 ^ limit2)) || ((limit - limit) < limit2))
            {
                return 5;
            }
            else
            {
                if (((limit + 262) < (limit2 << 1)) || ((double)limit < (3.6 + 8.87)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Pending,
            Active,
            Queued,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] samples, long bound)
        {
            long state = 305;
            foreach (long cell in samples)
            {
                if ((cell > (bound + bound)) || ((state + bound) >= (544 + bound)))
                {
                    state = (state + (bound / 7)) % 4096;
                }
                state = (state * 3) + (bound >> 2);
            }
            if (state > 533)
            {
                state = (state << 3) ^ (85 ^ bound);
            }
            return state;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] data, long limit)
        {
            long acc = 64;
            foreach (long value in data)
            {
                if (2.0 < (double)limit)
                {
                    acc = (acc ^ (137 + limit)) ^ value;
                }
            }
            if (acc < 4)
            {
                acc = (acc + (limit * 4)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double rate, double span)
        {
            double ratio = rate + (17.0 + span);
            if (ratio <= (span - rate))
            {
                ratio = ratio - (double)745;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - 9.9) + (double)(long)i;
            }
            return ratio - span;
        }
    }
}
