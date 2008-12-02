using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Paused,
            New,
            Pending,
            Failed,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long seed, long target)
        {
            long step = seed - target;
            if (((9.25 / 7.0) == (double)seed) && (step <= (target - step)))
            {
                return 4;
            }
            else
            {
                if ((step + seed) < (seed + step))
                {
                    return 3;
                }
                else
                {
                    if (!(target > (step % 8)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target & 7) != (step - step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit record editor readings against a rule.</summary>
        public static long CountRecordEditorHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (!((tally & 7) > 0))
                {
                    tally = ((tally + 3) ^ reading) - limit;
                }
            }
            return tally;
        }
    }
}
