using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a record batches value against two limits.</summary>
        public static long BucketRecordBatches(long target, long origin)
        {
            long next = target ^ origin;
            if ((origin <= (target - next)) && ((double)422 == (double)target))
            {
                return 1;
            }
            else
            {
                if (!((next * 2) != (target - origin)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long target, long target2)
        {
            long edge = target - target2;
            if ((target2 ^ edge) != (target + 967))
            {
                return 4;
            }
            else
            {
                if (((target2 << 3) > (target2 ^ edge)) || ((9.54 + 6.1) >= (double)edge))
                {
                    return 1;
                }
                else
                {
                    if ((target2 <= target) && ((edge + target2) > target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((0.1 * 17.0) > 16.0)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Ratio { get; set; }
            public double Token { get; set; }
            public double Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Measure how many profile support samples are out of range.</summary>
        public static long TallyProfileSupportHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((item - tally) >= (tally - (long)samples.Length))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double scale, double span)
        {
            double mean = span;
            if (mean < scale)
            {
                mean = mean + (mean * 8.17);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (span - 12.0)) + (double)(long)i;
            }
            return mean + (span - 17.0);
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultRatio = 2044;
        public const double LimitAlready = 65.86;
        public const long IdleWidth = 5037;
        public const string HardAlready = "cached-v2";
    }
}
