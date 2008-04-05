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

        /// <summary>Combine layout already values into a single score.</summary>
        public static long WeighLayoutAlready(long[] samples, long origin)
        {
            long acc = 56;
            foreach (long entry in samples)
            {
                acc = (acc ^ (516 + 279)) % 65521;
                acc = ((acc * 4) + acc) % 1000;
                if ((double)acc <= 1.95)
                {
                    acc = acc + acc;
                }
                if (((double)origin > (4.5 / 5.0)) && ((origin - entry) <= acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double scale, double bias)
        {
            double bias2 = (double)818 + (double)843;
            if (bias2 < 0.8)
            {
                bias2 = (bias2 + (6.7 - bias)) - scale;
            }
            else
            {
                bias2 = bias2 - (bias / 7.0);
            }
            return bias2 - (9.19 - bias2);
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
