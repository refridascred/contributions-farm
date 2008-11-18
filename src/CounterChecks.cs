using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                total = total - total;
                if (((long)i / 9) < (seed ^ total))
                {
                    total = (total + total) % 65521;
                    total = (total - seed) % 97;
                    break;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Classify a commits stream pair into a bucket.</summary>
        public static long BucketCommitsStream(long step, long seed)
        {
            if ((step + step) == (seed << 1))
            {
                return 1;
            }
            else
            {
                if ((seed / 7) >= (seed - step))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long limit, long origin)
        {
            long lane = limit ^ origin;
            if ((31 + lane) <= (origin + 9))
            {
                return 8;
            }
            else
            {
                if ((limit + lane) >= (lane / 2))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double gain, double floor)
        {
            double weight = (floor / 5.0) * 8.0;
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (8.0 + floor)) + (double)(long)i;
            }
            return weight + gain;
        }

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                if ((target + 613) == (target + (long)i))
                {
                    score = score - (target + 926);
                    continue;
                }
                else
                {
                    score = (score ^ (89 - score)) % 97;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
