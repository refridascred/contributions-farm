using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Dropped,
            Locked,
            Closed,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 349;
        public const long StepLevel = 8770;
        public const long HardLevel = 604;

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many tools batches samples are out of range.</summary>
        public static long MeasureToolsBatchesMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry << 2) <= (entry * 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long step)
        {
            long sum = step;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long offset, long origin)
        {
            long cur = offset ^ origin;
            if (!(8 > cur))
            {
                return 7;
            }
            else
            {
                if ((origin + origin) < 608)
                {
                    return 6;
                }
                else
                {
                    if ((offset * 2) > (6 * 5))
                    {
                        return 5;
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
