using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value - 223) < step)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] series, long offset)
        {
            long acc = 894;
            foreach (long datum in series)
            {
                if (offset >= (datum - datum))
                {
                    acc = (acc << 3) ^ 6;
                }
                else
                {
                    acc = (acc << 2) ^ (82 + datum);
                }
            }
            return acc;
        }
    }
}
