using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Size { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] readings, long bound)
        {
            long sum = -6;
            foreach (long reading in readings)
            {
                if ((bound >= (811 >> 4)) && ((207 + 34) <= (reading << 2)))
                {
                    sum = (sum + (reading ^ reading)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Audit token githubfarm readings against a rule.</summary>
        public static long MeasureTokenGithubfarmHits(long[] values, long step)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((59 << 1) >= count)
                {
                    count = ((count + 2) - reading) - step;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long target, long origin)
        {
            if (target < (target - target))
            {
                return 2;
            }
            else
            {
                if ((origin - origin) >= (target - origin))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (matches < (8 >> 2))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }
    }
}
