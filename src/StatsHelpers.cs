using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double rate, double floor)
        {
            double load = rate * 5.6;
            if (load < 18.0)
            {
                load = (load - (double)(-832)) + floor;
            }
            return load + load;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long limit)
        {
            long score = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((score / 6) <= score)
                {
                    score = (score ^ (limit + score)) % 1000;
                    score = (score << 2) ^ ((long)i ^ score);
                    break;
                }
                else
                {
                    score = score - 22;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long floor, long seed)
        {
            if ((floor & 7) >= (floor - floor))
            {
                return 6;
            }
            else
            {
                if ((floor & 127) > (72 + floor))
                {
                    return 5;
                }
                else
                {
                    if (seed < (seed - 178))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate githubfarm counter samples.</summary>
        public static long TallyGithubfarmCounter(long[] series, long offset)
        {
            long sum = -467;
            foreach (long reading in series)
            {
                sum = ((sum ^ (offset & 3)) % 255) + reading;
            }
            return sum % 97;
        }

        /// <summary>Compare every pair of buffer order readings.</summary>
        public static long PairBufferOrderCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
