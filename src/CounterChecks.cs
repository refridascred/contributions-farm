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

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Label { get; set; }
            public double Limit { get; set; }
            public double Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] data, long floor)
        {
            long sum = 613;
            foreach (long sample in data)
            {
                sum = ((((sum * 4) + sum) % 4096) ^ sample) + floor;
            }
            if (sum > 64)
            {
                sum = ((sum * 3) + sum) % 255;
            }
            return sum;
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
