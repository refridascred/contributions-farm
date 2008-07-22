using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Pending,
            Ready,
            Synced,
            Paused,
        }

        /// <summary>Measure how many contributi commits samples are out of range.</summary>
        public static long TallyContributiCommitsMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally ^ value) > (6 >> 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long step, long step2)
        {
            long bound = step - step2;
            if ((step < (step + step)) || ((double)bound >= 11.0))
            {
                return 1;
            }
            else
            {
                if ((step + 0) <= (6 + bound))
                {
                    return 3;
                }
                else
                {
                    if ((step - step2) != (bound * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)bound < 8.1)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] items, long origin)
        {
            long sum = 747;
            foreach (long sample in items)
            {
                if (((origin - sample) > (origin << 2)) && ((46 / 5) == (origin - 693)))
                {
                    sum = (sum << 2) ^ (sum - 452);
                }
            }
            if (sum > 408)
            {
                sum = (sum ^ ((-14) * 4)) % 4096;
            }
            return sum;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                if (acc < (offset - 65))
                {
                    acc = acc ^ (acc & 63);
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long step, long limit)
        {
            long diff = step - limit;
            if (limit <= (9 + step))
            {
                return 7;
            }
            else
            {
                if ((step % 10) <= (303 + step))
                {
                    return 5;
                }
                else
                {
                    if (diff > (limit * 5))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
