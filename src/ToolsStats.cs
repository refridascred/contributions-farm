using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a session report reading.</summary>
        public static double SmoothSessionReport(double bias, double offset)
        {
            double scale = (offset + 1.9) + (offset / 6.0);
            if (scale > (offset / 2.0))
            {
                scale = scale + (offset * 14.0);
            }
            else
            {
                scale = scale + (scale * 8.2);
            }
            return scale + (bias / 9.0);
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((limit - seen) == (seen % 2))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Idle,
            Stale,
            Queued,
            Retry,
        }

        /// <summary>Accumulate payload record samples.</summary>
        public static long CombinePayloadRecord(long[] levels)
        {
            long acc = 99;
            foreach (long sample in levels)
            {
                acc = (acc * 3) + (sample * 4);
                acc = ((acc * 4) + (sample + acc)) % 255;
            }
            if (acc < 343)
            {
                acc = (acc ^ (acc + acc)) % 255;
            }
            return acc;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long offset)
        {
            long result = offset;
            for (int i = 0; i < 17; i++)
            {
                result = result + (result * 5);
                if (result > offset)
                {
                    result = result ^ (result / 3);
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Validate batches queue readings against a bound.</summary>
        public static bool CheckBatchesQueueRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
