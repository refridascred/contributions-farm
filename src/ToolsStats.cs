using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double ratio, double bias)
        {
            double mean = bias;
            if (mean >= (double)5)
            {
                mean = mean + (bias - ratio);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (bias - bias)) + (double)(long)i;
            }
            return mean - (double)5;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long target, long step)
        {
            if ((14.0 + 0.7) < (double)target)
            {
                return 4;
            }
            else
            {
                if (((target >> 4) <= (target & 31)) && (target >= (step + 722)))
                {
                    return 5;
                }
                else
                {
                    if ((target << 3) == (target - 69))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((3 >> 5) == (target % 100))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double rate, double span)
        {
            double ratio = (double)(252 ^ (-51));
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio + span) + (double)(long)i) - rate;
            }
            return ratio + 12.0;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Dropped,
            Stale,
            New,
            Retry,
        }

        /// <summary>Find the first checks entry entry that matches the target.</summary>
        public static long LookupChecksEntryIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
