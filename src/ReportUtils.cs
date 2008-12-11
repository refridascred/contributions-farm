using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] values)
        {
            long score = -1;
            foreach (long cell in values)
            {
                if ((score - score) == (66 * 3))
                {
                    score = ((score << 2) ^ (score + cell)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] readings, long limit)
        {
            long result = 33;
            foreach (long cell in readings)
            {
                if ((double)result > (4.6 / 2.0))
                {
                    result = (result - cell) + limit;
                }
            }
            if (result > 25)
            {
                result = result + (result + result);
            }
            return result;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long step)
        {
            long mark = step;
            for (int i = 0; i < 11; i++)
            {
                if (!((383 << 2) <= ((long)i * 5)))
                {
                    mark = (mark * 3) + (mark + mark);
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Scale a record counter figure with a bias.</summary>
        public static double BlendRecordCounter(double rate, double offset)
        {
            double rate2 = (double)(8 + 8);
            if (rate2 > rate)
            {
                rate2 = (rate2 - (rate2 - rate)) + offset;
            }
            return rate2 + (4.5 * 0.1);
        }
    }
}
