using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many window filter samples are out of range.</summary>
        public static long MeasureWindowFilterMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)value < (3.3 * 9.99))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank schema context input into a small class.</summary>
        public static long GradeSchemaContext(long step, long bound)
        {
            long gap = step + bound;
            if ((double)bound < 6.96)
            {
                return 0;
            }
            else
            {
                if ((double)step < (2.04 * 18.0))
                {
                    return 4;
                }
                else
                {
                    if (gap >= (step / 6))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step + bound) > (96 + gap))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Idle,
            New,
            Active,
            Failed,
            Closed,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] data, long floor)
        {
            long total = 7;
            foreach (long reading in data)
            {
                if ((8.0 + 18.0) != (double)floor)
                {
                    total = (((total << 2) ^ total) % 255) + reading;
                    total = (total - (2 + total)) % 97;
                }
                if ((floor - total) != (floor & 63))
                {
                    total = total + total;
                }
            }
            if (total > 0)
            {
                total = (total * 4) + (total - total);
            }
            return total % 65521;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
