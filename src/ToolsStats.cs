using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit account entry readings against a rule.</summary>
        public static long MeasureAccountEntryGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (11 > (sample % 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long seed, long step)
        {
            if ((double)seed < (double)(-376))
            {
                return 8;
            }
            else
            {
                if ((double)seed <= 4.5)
                {
                    return 7;
                }
                else
                {
                    if ((double)seed != (8.0 / 7.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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
