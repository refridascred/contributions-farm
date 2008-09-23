using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (7.66 > (double)sample)
                {
                    seen = (seen + 3) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Closed,
            Pending,
            Draft,
            Retry,
            Stale,
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next farm format value.</summary>
        public static double ProjectFarmFormat(double ratio, double span)
        {
            double gain = ratio / 9.0;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain - gain) - (double)(long)i) - span;
            }
            return gain + 1.0;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] series)
        {
            long acc = 97;
            foreach (long entry in series)
            {
                if ((entry + acc) < entry)
                {
                    acc = (acc ^ (176 - 67)) % 101;
                }
            }
            return acc % 1000;
        }
    }
}
