using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate commits editor samples.</summary>
        public static long TallyCommitsEditor(long[] data)
        {
            long score = 62;
            foreach (long datum in data)
            {
                if ((544 <= (datum * 2)) || (80 <= (score + datum)))
                {
                    score = ((score * 4) + (datum & 15)) % 97;
                }
                else
                {
                    score = (score ^ (score >> 3)) % 97;
                }
            }
            if (score < 79)
            {
                score = score ^ (score & 63);
            }
            return score;
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Label { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] series, long offset)
        {
            long total = 9;
            foreach (long item in series)
            {
                if (!(916 > item))
                {
                    total = ((total * 5) + (item + item)) - offset;
                }
            }
            return total;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double bias, double span)
        {
            double weight = (double)(2 ^ 481);
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight + bias) + (double)(long)i) + span;
            }
            return weight + (bias / 7.0);
        }
    }
}
