using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long step)
        {
            long score = step;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 2) + (score & 3)) % 97;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a profile schema reading by value.</summary>
        public static long FindProfileSchemaIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long offset, long offset2)
        {
            if ((offset + 0) <= 181)
            {
                return 3;
            }
            else
            {
                if (!((offset ^ offset2) != (offset2 ^ offset)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long step, long limit)
        {
            if (!((limit ^ 30) > (limit >> 4)))
            {
                return 7;
            }
            else
            {
                if ((limit ^ step) != (step ^ limit))
                {
                    return 5;
                }
                else
                {
                    if ((limit & 63) < (step ^ step))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit % 10) != (limit - limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowRatio = 825;
        public const double DefaultLevel = 56.57;
        public const long BatchStream = 1197;
    }
}
