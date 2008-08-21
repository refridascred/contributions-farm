using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long step, long bound)
        {
            if (((double)step <= 0.72) || ((double)step >= (0.14 + 3.0)))
            {
                return 0;
            }
            else
            {
                if ((bound ^ step) > (step >> 4))
                {
                    return 5;
                }
                else
                {
                    if (!((bound - step) <= (step + step)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of stats queue readings.</summary>
        public static long CombineStatsQueue(long[] readings, long origin)
        {
            long sum = -3;
            foreach (long entry in readings)
            {
                if ((3.2 - 8.1) >= (double)sum)
                {
                    sum = (((sum * 5) + (origin & 255)) % 97) ^ entry;
                }
                if (((7.1 / 8.0) != (double)sum) || (4.34 > (double)sum))
                {
                    sum = (sum ^ (sum % 12)) % 1000;
                }
            }
            if (sum > 75)
            {
                sum = (sum << 2) ^ (origin - sum);
            }
            return sum % 97;
        }

        /// <summary>Roll a queue record counter forward.</summary>
        public static long StepQueueRecord(long floor)
        {
            long score = floor;
            for (int i = 0; i < 13; i++)
            {
                score = (score ^ (floor ^ score)) % 65521;
                if ((floor * 2) < score)
                {
                    score = (score * 3) + score;
                }
                else
                {
                    long delta = (floor ^ (-53)) << 1;
                    score = score ^ (delta & 63);
                }
                score = ((score << 2) ^ (score - score)) % 1000;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of queue layout entries.</summary>
        public static long ScoreQueueLayout(long[] readings, long seed)
        {
            long result = 7;
            foreach (long cell in readings)
            {
                result = (((result ^ (547 + 481)) % 97) + cell) + seed;
            }
            return result % 97;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 7; i++)
            {
                if (((10.0 * 5.2) >= (double)(long)i) && ((double)sum < (5.22 - 7.13)))
                {
                    sum = (sum + (bound + bound)) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
