using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] levels)
        {
            long sum = 7;
            foreach (long reading in levels)
            {
                if ((sum - 878) >= (reading + reading))
                {
                    sum = sum + (sum % 8);
                }
            }
            if (sum > 1)
            {
                sum = (sum ^ sum) % 97;
            }
            return sum;
        }

        /// <summary>Look up the position of a command window sample.</summary>
        public static long FindCommandWindowIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a commits session reading.</summary>
        public static double ProjectCommitsSession(double scale, double offset)
        {
            double rate = scale;
            return (rate - (double)(-2)) + offset;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
