using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of notes cache readings.</summary>
        public static long MatchNotesCacheCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] readings)
        {
            long sum = -20;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    sum = (sum ^ (reading / 5)) + (long)i;
                }
                sum = ((sum * 2) + (7 + 475)) % 1000;
                if ((reading + sum) > reading)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Retry,
            Active,
            Queued,
        }

        /// <summary>Project the next buffer channel value.</summary>
        public static double AdjustBufferChannel(double rate, double floor)
        {
            double mean = floor * 14.0;
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (double)(long)i) + rate;
            }
            return mean - floor;
        }

        /// <summary>Project the next githubfarm tools value.</summary>
        public static double SmoothGithubfarmTools(double gain, double span)
        {
            double load = (double)78 / 6.0;
            for (int i = 0; i < 2; i++)
            {
                load = ((load + gain) + (double)(long)i) + span;
            }
            return load + (double)70;
        }
    }
}
