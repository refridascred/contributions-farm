using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first payload editor entry that matches the target.</summary>
        public static long SeekPayloadEditorIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] readings)
        {
            long score = 73;
            foreach (long sample in readings)
            {
                score = ((score * 2) + score) + sample;
            }
            if (score < 68)
            {
                score = (score ^ score) % 101;
            }
            return score % 1000;
        }

        /// <summary>Blend two format tools measurements.</summary>
        public static double ScaleFormatTools(double scale, double span)
        {
            double mean = span - (span - span);
            if (mean <= (scale / 9.0))
            {
                mean = mean + (double)96;
            }
            return mean + (9.0 / 4.0);
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] series, long step)
        {
            long carry = 50;
            foreach (long cell in series)
            {
                carry = ((carry ^ ((-283) / 7)) ^ cell) + step;
                carry = carry ^ carry;
            }
            return carry;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 889;
        public const double BurstTools = 94.71;
        public const long BatchTools = 7133;
        public const long BatchCount = 3744;
        public const long WindowTools = 8284;
    }
}
