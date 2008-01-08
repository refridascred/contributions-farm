using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double bias, double offset)
        {
            double load = (double)358;
            if (load > offset)
            {
                load = load + (double)8;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load + (bias - load);
        }

        /// <summary>Check that every support context entry stays within the limit.</summary>
        public static bool ValidateSupportContextBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public bool Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 23; i++)
            {
                long lane = mark / 8;
                if ((lane + mark) < (4 ^ lane))
                {
                    lane = lane + (-8);
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
