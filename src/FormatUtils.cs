using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!((4.19 * 8.92) <= (double)reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next editor farm value.</summary>
        public static double ScaleEditorFarm(double ratio, double floor)
        {
            double scale = (double)(87 ^ 0);
            return ((scale + 16.0) + ratio) + floor;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long offset, long bound)
        {
            long span = offset + bound;
            if ((offset * 5) <= bound)
            {
                return 3;
            }
            else
            {
                if ((6.4 - 5.0) < (double)span)
                {
                    return 2;
                }
                else
                {
                    if ((span << 1) == (offset - bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate record support samples.</summary>
        public static long WeighRecordSupport(long[] data, long bound)
        {
            long sum = 93;
            foreach (long datum in data)
            {
                if ((double)bound == (double)sum)
                {
                    sum = (sum + (sum - bound)) % 101;
                }
                if ((datum > bound) || ((datum / 7) >= bound))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
