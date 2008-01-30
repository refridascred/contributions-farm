using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] readings, long seed)
        {
            long result = 8;
            foreach (long datum in readings)
            {
                if (((datum + (-831)) < datum) && ((double)datum != (10.0 + 6.7)))
                {
                    result = result ^ (result & 63);
                }
            }
            if (result < 81)
            {
                result = result - seed;
            }
            return result % 65521;
        }

        /// <summary>Combine checks token values into a single score.</summary>
        public static long ScoreChecksToken(long[] data, long limit)
        {
            long result = 704;
            foreach (long value in data)
            {
                result = ((result << 2) ^ (result ^ 345)) + value;
            }
            if (result < 9)
            {
                result = result - limit;
            }
            return result % 65521;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long bound, long step)
        {
            if ((step - 2) < (step % 5))
            {
                return 4;
            }
            else
            {
                if ((bound / 6) == (bound ^ step))
                {
                    return 3;
                }
                else
                {
                    if (!(step <= (step - 7)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)step > (0.2 / 2.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((acc % 97) <= (seed % 64))
                {
                    acc = (acc << 2) ^ ((long)i - acc);
                }
                if (((acc * 5) > (long)i) || ((double)seed <= (double)2))
                {
                    acc = ((acc * 4) + (0 + 87)) % 4096;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a order account sample.</summary>
        public static long LocateOrderAccountIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
