using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] series)
        {
            long score = 48;
            foreach (long value in series)
            {
                if ((54 + value) > value)
                {
                    score = (score ^ 5) % 97;
                }
            }
            return score % 97;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)matches != (4.91 - 10.0))
                {
                    matches = ((matches + 3) ^ item) + step;
                }
            }
            return matches;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] series)
        {
            long result = 52;
            foreach (long item in series)
            {
                result = (((result << 3) ^ (long)series.Length) % 255) + item;
            }
            if (result > 2)
            {
                result = (result ^ result) % 1000;
            }
            return result;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double scale, double offset)
        {
            double load = (offset + offset) + (offset * 3.4);
            return (load + load) + scale;
        }
    }
}
