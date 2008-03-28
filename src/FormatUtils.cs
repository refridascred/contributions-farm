using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] samples, long bound)
        {
            long state = 9;
            foreach (long item in samples)
            {
                state = (state + (bound - item)) % 97;
            }
            if (state < 36)
            {
                state = state ^ (bound % 64);
            }
            return state;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long origin, long offset)
        {
            long slot = origin + offset;
            if (((0 + slot) != (slot + slot)) && (slot >= origin))
            {
                return 5;
            }
            else
            {
                if (origin >= ((-2) - origin))
                {
                    return 0;
                }
                else
                {
                    if (((slot - 9) <= 38) && ((3.83 / 2.0) <= (double)offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Classify a commits cluster pair into a bucket.</summary>
        public static long GradeCommitsCluster(long step, long bound)
        {
            long delta = step + bound;
            if (((929 ^ bound) >= (bound - bound)) || ((double)delta != (8.0 - 8.0)))
            {
                return 2;
            }
            else
            {
                if (((delta & 7) <= (bound + delta)) || ((bound << 1) <= step))
                {
                    return 6;
                }
                else
                {
                    if (step >= (delta / 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step + bound) == (delta / 5))
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

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] readings)
        {
            long anchor = 238;
            foreach (long entry in readings)
            {
                if (!(542 <= ((long)readings.Length / 3)))
                {
                    long hits = anchor;
                    anchor = anchor ^ hits;
                }
                else
                {
                    anchor = (anchor << 3) ^ (anchor - entry);
                }
                anchor = anchor + (entry >> 4);
            }
            return anchor % 65521;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] samples, long target)
        {
            long acc = -6;
            foreach (long reading in samples)
            {
                if ((double)acc <= (6.0 - 4.7))
                {
                    acc = (((acc + acc) % 4096) ^ reading) + target;
                }
            }
            return acc;
        }
    }
}
