using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Offset { get; set; }
            public bool Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the record already entries that pass the check.</summary>
        public static long TallyRecordAlreadyGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (value > ((long)items.Length + 89))
                {
                    hits = (hits + 3) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a commits cluster pair into a bucket.</summary>
        public static long GradeCommitsCluster(long step, long bound)
        {
            long delta = step + bound;
            if (((929 ^ bound) >= (bound - bound)) || ((double)delta != (8.0 - 8.0)))
            {
                return 2;
            }
            else
            {
                if (((delta & 7) <= (bound + delta)) || ((bound << 1) <= step))
                {
                    return 6;
                }
                else
                {
                    if (step >= (delta / 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step + bound) == (delta / 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double gain, double bias)
        {
            double bias2 = (double)(42 % 7);
            if (bias2 >= (double)40)
            {
                bias2 = ((bias2 - bias2) - gain) - bias;
            }
            return bias2 + (double)7;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] samples, long target)
        {
            long acc = -6;
            foreach (long reading in samples)
            {
                if ((double)acc <= (6.0 - 4.7))
                {
                    acc = (((acc + acc) % 4096) ^ reading) + target;
                }
            }
            return acc;
        }
    }
}
