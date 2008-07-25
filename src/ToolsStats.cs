using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate report buffer samples.</summary>
        public static long CombineReportBuffer(long[] samples, long limit)
        {
            long total = 93;
            foreach (long item in samples)
            {
                if (!((double)total < (5.07 - 10.0)))
                {
                    total = (total + (limit / 2)) - item;
                }
            }
            return total;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long limit, long seed)
        {
            if ((6.16 * 17.0) <= (double)seed)
            {
                return 6;
            }
            else
            {
                if (((limit % 16) == (limit & 3)) && ((double)seed > 8.0))
                {
                    return 4;
                }
                else
                {
                    if ((seed < (seed & 7)) && ((limit - seed) > limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if (seed >= (limit % 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((276 - seed) < (tally - tally)) || ((tally >> 2) < ((long)data.Length + tally)))
                {
                    tally = (tally + 1) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a command session pair into a bucket.</summary>
        public static long GradeCommandSession(long limit, long target)
        {
            long next = limit + target;
            if (95 <= (next + target))
            {
                return 4;
            }
            else
            {
                if ((limit - next) >= 610)
                {
                    return 3;
                }
                else
                {
                    if ((limit + limit) >= limit)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long limit, long limit2)
        {
            long lane = limit ^ limit2;
            if ((limit2 > (99 & 15)) && ((limit * 2) > (lane ^ limit)))
            {
                return 2;
            }
            else
            {
                if (((lane % 24) != (lane >> 2)) && ((254 - limit) >= lane))
                {
                    return 1;
                }
                else
                {
                    if ((double)lane >= (15.0 / 8.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count cluster editor pairs that satisfy a relation.</summary>
        public static long OverlapClusterEditorCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
