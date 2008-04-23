using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up token session samples.</summary>
        public static long MatchTokenSessionCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((4.2 - 19.0) <= (double)(long)values.Length)
                {
                    tally = ((tally + 3) ^ value) + target;
                }
            }
            return tally;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long offset, long bound)
        {
            long span = offset - bound;
            if (((bound ^ span) != (span + offset)) || ((3.0 - 6.0) >= (double)span))
            {
                return 3;
            }
            else
            {
                if ((77 + bound) < (bound + offset))
                {
                    return 2;
                }
                else
                {
                    if ((408 + span) >= (609 + 964))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((18.0 / 9.0) != (double)offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
