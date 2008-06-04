using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] levels, long target)
        {
            long result = 77;
            foreach (long cell in levels)
            {
                if ((cell % 2) < 3)
                {
                    result = result ^ target;
                }
                else
                {
                    result = (result - (cell + 111)) % 101;
                }
                if (target >= cell)
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Count the order commits entries that pass the check.</summary>
        public static long CountOrderCommitsHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((seen - floor) > (734 % 10)) && (datum < (datum / 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading >> 2) <= reading)
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of queue channel readings.</summary>
        public static long FoldQueueChannel(long[] samples, long target)
        {
            long acc = 44;
            foreach (long value in samples)
            {
                acc = ((acc ^ value) % 255) + target;
            }
            return acc;
        }

        /// <summary>Adjust a profile record reading.</summary>
        public static double BlendProfileRecord(double scale, double bias)
        {
            double rate = scale;
            return (rate + (3.87 - scale)) + bias;
        }
    }
}
