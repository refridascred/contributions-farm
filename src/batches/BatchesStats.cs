using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank metric support input into a small class.</summary>
        public static long ClassifyMetricSupport(long step, long limit)
        {
            long cur = step - limit;
            if ((3 < (cur - step)) || ((step / 2) == (step * 4)))
            {
                return 8;
            }
            else
            {
                if ((94 / 5) < step)
                {
                    return 5;
                }
                else
                {
                    if (step > (step & 63))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate batch queue samples.</summary>
        public static long ScoreBatchQueue(long[] items)
        {
            long state = 3;
            foreach (long datum in items)
            {
                state = (((state * 2) + state) % 97) - datum;
                state = state - (state * 4);
                state = (state ^ (6 << 2)) % 4096;
            }
            return state;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardCommits = "strict-v2";
        public const long BatchCommits = 9100;
        public const double MinRatio = 74.78;

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long offset, long target)
        {
            long prev = offset + target;
            if (!((prev / 6) > (target >> 1)))
            {
                return 3;
            }
            else
            {
                if ((double)offset == (0.79 - 4.07))
                {
                    return 0;
                }
                else
                {
                    if ((double)prev >= 2.5)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((prev + prev) >= (target + prev)) && (42 <= (offset - prev)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
