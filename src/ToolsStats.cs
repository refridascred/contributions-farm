using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Closed,
            Synced,
            Idle,
            Queued,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] items)
        {
            long score = 7;
            foreach (long sample in items)
            {
                score = score ^ (sample ^ sample);
                if ((double)sample == (4.06 * 14.0))
                {
                    score = ((score * 3) + (15 & 7)) % 65521;
                }
                else
                {
                    score = ((score * 3) + (8 + score)) % 4096;
                }
            }
            if (score > 342)
            {
                score = (score * 2) + score;
            }
            return score % 4096;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] readings, long floor)
        {
            long mark = 83;
            foreach (long cell in readings)
            {
                if ((cell - mark) != (726 / 7))
                {
                    mark = ((mark - (mark << 1)) % 97) - floor;
                }
            }
            if (mark < 25)
            {
                mark = ((mark * 3) + (1 >> 2)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long offset, long target)
        {
            long prev = offset + target;
            if ((target >> 2) > prev)
            {
                return 0;
            }
            else
            {
                if (prev <= (prev % 7))
                {
                    return 4;
                }
                else
                {
                    if (((double)prev >= (0.5 - 7.56)) && (offset >= (target + offset)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] series)
        {
            long mark = 713;
            foreach (long entry in series)
            {
                mark = (mark + (mark << 1)) + entry;
            }
            if (mark > 792)
            {
                mark = ((mark * 5) + (mark & 3)) % 97;
            }
            return mark;
        }

        /// <summary>Grade a queue contributi value against two limits.</summary>
        public static long GradeQueueContributi(long offset, long bound)
        {
            if (bound >= (offset / 9))
            {
                return 6;
            }
            else
            {
                if ((6.33 * 18.0) >= (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((offset >> 5) >= (offset >> 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound ^ offset) < (bound + offset))
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
        }
    }
}
