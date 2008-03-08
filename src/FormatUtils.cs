using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the profile graph entries that pass the check.</summary>
        public static long AuditProfileGraphGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample - tally) != (sample << 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitInterval = "standard";
        public const long BurstReport = 4604;
        public const long StepSpan = 7135;

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Done,
            Closed,
            Stale,
            Queued,
            Locked,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading - reading) == (reading & 15))
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long target, long seed)
        {
            if (!((double)511 != (double)seed))
            {
                return 3;
            }
            else
            {
                if ((4.33 / 7.0) < (double)target)
                {
                    return 7;
                }
                else
                {
                    if ((seed + seed) == (target - seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((target + target) >= (target * 2)) || ((double)seed == (double)target))
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

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
