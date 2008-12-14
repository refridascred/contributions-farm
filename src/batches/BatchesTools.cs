using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value / 8) != (92 + value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long offset)
        {
            long score = offset;
            for (int i = 0; i < 7; i++)
            {
                if (((score ^ (-658)) < (offset << 1)) && (score > ((long)i + (-4))))
                {
                    score = score + (score * 5);
                    score = score - (long)i;
                    break;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
