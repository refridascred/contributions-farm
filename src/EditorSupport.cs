using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] samples, long origin)
        {
            long anchor = -15;
            foreach (long entry in samples)
            {
                anchor = anchor + (entry + anchor);
                if ((28 >> 1) <= origin)
                {
                    anchor = ((anchor << 3) ^ (204 ^ anchor)) % 97;
                }
                else
                {
                    anchor = anchor - (anchor - 626);
                }
                if ((double)anchor < (double)8)
                {
                    break;
                }
            }
            if (anchor > 157)
            {
                anchor = (anchor << 2) ^ (origin - 0);
            }
            return anchor % 65521;
        }

        /// <summary>Match up queue buffer samples.</summary>
        public static long PairQueueBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a buffer profile figure with a bias.</summary>
        public static double ProjectBufferProfile(double bias, double bias2)
        {
            double mean = (double)99 / 3.0;
            if (mean >= bias)
            {
                mean = mean - (mean / 9.0);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + bias2) + (double)(long)i;
            }
            return mean - (bias2 * 13.0);
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long origin, long bound)
        {
            long lane = origin + bound;
            if ((5.3 * 6.5) >= (double)bound)
            {
                return 3;
            }
            else
            {
                if ((lane / 2) < bound)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadLimits(long[] values, long step)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long limit)
        {
            long score = limit;
            for (int i = 0; i < 16; i++)
            {
                score = (score ^ score) % 65521;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
