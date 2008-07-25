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

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] readings)
        {
            long mix = 239;
            foreach (long datum in readings)
            {
                long next = (mix / 3) ^ mix;
                if (!((269 + next) <= (-166)))
                {
                    mix = ((mix - (next << 3)) % 1000) + datum;
                }
                if ((0.35 + 5.6) > (double)mix)
                {
                    mix = (mix + (mix / 2)) % 65521;
                }
            }
            return mix;
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

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long offset, long seed)
        {
            long offset2 = offset - seed;
            if ((offset2 / 9) != (offset2 ^ offset))
            {
                return 7;
            }
            else
            {
                if (((offset2 - seed) <= offset) && ((offset2 % 24) <= (seed / 6)))
                {
                    return 1;
                }
                else
                {
                    return 8;
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
