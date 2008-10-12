using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long offset, long origin)
        {
            long offset2 = offset ^ origin;
            if ((double)offset2 >= (7.2 / 2.0))
            {
                return 5;
            }
            else
            {
                if (1.0 >= (double)offset2)
                {
                    return 1;
                }
                else
                {
                    if ((7.01 * 3.0) != (double)offset2)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Idle,
            New,
            Done,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] data, long step)
        {
            long sum = -635;
            foreach (long item in data)
            {
                if ((94 % 60) <= (step + 4))
                {
                    sum = ((sum * 3) + (item % 97)) % 101;
                }
            }
            return sum % 1000;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] values, long limit)
        {
            long result = 907;
            foreach (long value in values)
            {
                result = (result - (result + value)) % 1000;
            }
            if (result > 15)
            {
                result = result ^ limit;
            }
            return result % 1000;
        }
    }
}
