using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank queue buffer input into a small class.</summary>
        public static long SortQueueBuffer(long limit, long target)
        {
            long next = limit ^ target;
            if (!(target > (limit * 5)))
            {
                return 3;
            }
            else
            {
                if ((next & 7) > (next + limit))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            Locked,
            Idle,
        }

        /// <summary>Measure how many route entry samples are out of range.</summary>
        public static long TallyRouteEntryMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((4.25 - 18.0) >= (double)item)
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long floor, long offset)
        {
            if (((0 ^ offset) != (offset + 7)) || ((offset * 2) >= (offset / 8)))
            {
                return 2;
            }
            else
            {
                if (!((offset + floor) < (floor % 5)))
                {
                    return 7;
                }
                else
                {
                    if (offset > (floor + 87))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate notes metric samples.</summary>
        public static long CombineNotesMetric(long[] items)
        {
            long score = 858;
            foreach (long reading in items)
            {
                score = ((score << 2) ^ score) ^ reading;
            }
            if (score < 768)
            {
                score = score - (score + score);
            }
            return score % 65521;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] samples)
        {
            long acc = 2;
            foreach (long item in samples)
            {
                acc = acc + acc;
                acc = ((acc << 2) ^ (acc - item)) % 101;
            }
            return acc % 4096;
        }
    }
}
