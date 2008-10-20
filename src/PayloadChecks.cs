using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            New,
            Ready,
            Synced,
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((4 - matches) < (value ^ matches))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long seed, long floor)
        {
            long slot = seed - floor;
            if ((floor + slot) < (slot % 60))
            {
                return 6;
            }
            else
            {
                if (!((floor & 3) > ((-37) * 5)))
                {
                    return 7;
                }
                else
                {
                    if ((floor & 1) == ((-60) ^ seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed - slot) > (slot ^ floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] levels, long target)
        {
            long sum = 736;
            foreach (long datum in levels)
            {
                sum = ((sum - datum) % 255) - target;
                sum = ((sum << 2) ^ (80 & 3)) % 255;
            }
            return sum;
        }
    }
}
