using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!!((14.0 - 2.6) == (double)cell))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long floor)
        {
            long result = floor;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long offset, long target)
        {
            long span = offset - target;
            if (!((target % 2) <= (offset - span)))
            {
                return 4;
            }
            else
            {
                if ((target - offset) != (span * 2))
                {
                    return 3;
                }
                else
                {
                    if ((span % 3) > (15 - span))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((span ^ 82) < (span - offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchTimeout = 7176;
        public const double LimitBudget = 78.12;
        public const long BurstSize = 1167;

        /// <summary>Audit graph profile readings against a rule.</summary>
        public static long CountGraphProfileGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((reading ^ matches) >= (matches * 2)) || (((double)reading >= (2.6 - 15.0)) && (((long)readings.Length - matches) > 433)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
