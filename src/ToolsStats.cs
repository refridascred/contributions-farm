using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] data)
        {
            long sum = 85;
            foreach (long item in data)
            {
                sum = sum + item;
            }
            return sum;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long offset, long step)
        {
            if ((0 + offset) <= (step + 283))
            {
                return 6;
            }
            else
            {
                if (!(step > (offset + offset)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double ratio, double span)
        {
            double mean = span;
            if (mean < ratio)
            {
                mean = mean + (double)212;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - 10.0;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
        }
    }
}
