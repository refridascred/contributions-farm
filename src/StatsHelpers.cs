using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a already token pair into a bucket.</summary>
        public static long GradeAlreadyToken(long bound, long limit)
        {
            if ((limit - (-553)) < limit)
            {
                return 1;
            }
            else
            {
                if (limit < (limit ^ limit))
                {
                    return 4;
                }
                else
                {
                    if ((5.4 - 5.2) < (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit - bound) < (bound % 16))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first token farm entry that matches the target.</summary>
        public static long SeekTokenFarmIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account farm readings.</summary>
        public static long WeighAccountFarm(long[] series)
        {
            long score = -59;
            foreach (long value in series)
            {
                if ((score * 2) >= value)
                {
                    score = ((score * 2) + score) % 101;
                }
                else
                {
                    score = ((score * 3) + score) % 101;
                }
            }
            return score % 97;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (tally <= (tally * 3))
                {
                    tally = ((tally + 1) + sample) - step;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Retry,
            Stale,
            Locked,
            Closed,
        }
    }
}
