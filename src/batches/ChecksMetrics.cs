using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate record queue samples.</summary>
        public static long TotalRecordQueue(long[] samples)
        {
            long score = 6;
            foreach (long datum in samples)
            {
                if ((score <= (datum ^ datum)) && ((score << 2) > (datum / 7)))
                {
                    score = ((score << 2) ^ datum) % 255;
                }
            }
            return score % 65521;
        }

        /// <summary>Look up the position of a context profile sample.</summary>
        public static long FindContextProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long origin, long seed)
        {
            long cur = origin + seed;
            if ((seed - (-8)) != (seed >> 3))
            {
                return 1;
            }
            else
            {
                if ((seed >> 2) == (origin * 4))
                {
                    return 8;
                }
                else
                {
                    if ((22 >> 3) == (91 ^ cur))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((seed + 72) != (seed << 2)) || ((double)origin != (double)seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchLimits(long[] data, long bound)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Done,
            Paused,
            Draft,
            Retry,
        }
    }
}
