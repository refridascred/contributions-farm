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

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Pending,
            Locked,
            Failed,
            Done,
        }
    }
}
