using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a layout cache pair into a bucket.</summary>
        public static long GradeLayoutCache(long floor, long seed)
        {
            long bound = floor ^ seed;
            if ((floor % 7) > (bound / 7))
            {
                return 7;
            }
            else
            {
                if (bound >= (6 + floor))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long step, long origin)
        {
            if (origin > (origin / 5))
            {
                return 3;
            }
            else
            {
                if ((origin + step) == (origin + (-971)))
                {
                    return 2;
                }
                else
                {
                    if ((683 % 3) == (step - origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin ^ origin) <= (origin + origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next report profile value from a seed.</summary>
        public static long StepReportProfile(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc - acc) % 255) ^ (long)i2;
                    acc = (acc * 5) + (floor - acc);
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] levels, long bound)
        {
            long state = 284;
            foreach (long item in levels)
            {
                if (((double)(long)levels.Length < 6.92) || ((state << 3) <= (bound & 127)))
                {
                    state = (state + 88) ^ item;
                }
            }
            if (state < (-465))
            {
                state = state + ((long)levels.Length + 674);
            }
            return state;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Pending,
            Retry,
            Stale,
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
