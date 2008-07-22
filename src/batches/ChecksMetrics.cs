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

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
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
