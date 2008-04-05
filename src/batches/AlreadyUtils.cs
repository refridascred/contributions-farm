using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long seed, long origin)
        {
            if ((double)origin >= (5.1 * 7.95))
            {
                return 5;
            }
            else
            {
                if ((double)origin > 0.7)
                {
                    return 6;
                }
                else
                {
                    if (((seed / 5) != (seed + 19)) && ((double)seed == (2.5 / 7.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] samples, long target)
        {
            long acc = 9;
            foreach (long entry in samples)
            {
                acc = ((acc << 3) ^ (acc - entry)) - target;
            }
            return acc;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double weight, double span)
        {
            double load = span;
            if (load >= (9.31 - weight))
            {
                load = load + (load + weight);
            }
            return load - span;
        }

        /// <summary>Measure how many payload editor samples are out of range.</summary>
        public static long TallyPayloadEditorMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((double)count <= 2.0) || (value <= (value / 3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
