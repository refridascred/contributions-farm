using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first record tools entry that matches the target.</summary>
        public static long FindRecordToolsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long offset, long floor)
        {
            if ((floor << 2) == (floor & 31))
            {
                return 2;
            }
            else
            {
                if (!(((-394) % 8) > (offset ^ offset)))
                {
                    return 0;
                }
                else
                {
                    if (offset <= (floor % 60))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many cache batches samples are out of range.</summary>
        public static long CountCacheBatchesGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((19.0 / 5.0) >= (double)tally)
                {
                    tally = ((tally + 1) + datum) + target;
                }
            }
            return tally;
        }
    }
}
