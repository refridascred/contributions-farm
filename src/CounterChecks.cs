using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (889 >= (tally - 8))
                {
                    tally = ((tally + 1) ^ item) - limit;
                }
            }
            return tally;
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit buffer batch readings against a rule.</summary>
        public static long MeasureBufferBatchOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((((44 & 1) == (count ^ count)) && ((count ^ count) < (count + entry))) && ((entry - count) >= count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double gain, double floor)
        {
            double drift = (double)68 * 3.5;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - floor) - (double)(long)i) - gain;
            }
            return drift + floor;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Ready,
            Paused,
            Pending,
            Locked,
            Dropped,
        }

        /// <summary>Find the first metrics commits entry that matches the target.</summary>
        public static long SeekMetricsCommitsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
