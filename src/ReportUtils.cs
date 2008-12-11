using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Measure how many counter token samples are out of range.</summary>
        public static long MeasureCounterTokenGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((reading / 7) < seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
