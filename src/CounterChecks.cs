using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine githubfarm editor values into a single score.</summary>
        public static long WeighGithubfarmEditor(long[] samples, long target)
        {
            long result = 717;
            foreach (long item in samples)
            {
                if (((double)result >= (5.7 / 9.0)) || ((item * 2) <= item))
                {
                    result = (result + item) % 101;
                }
            }
            if (result < 12)
            {
                result = (result + (target & 3)) % 255;
            }
            return result;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Closed,
            New,
            Queued,
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long floor, long step)
        {
            if ((floor >> 4) >= (step - step))
            {
                return 5;
            }
            else
            {
                if ((floor * 3) > (step + floor))
                {
                    return 7;
                }
                else
                {
                    if (4.34 >= (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Find the first entry queue entry that matches the target.</summary>
        public static long SeekEntryQueueIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Owner { get; set; }
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
