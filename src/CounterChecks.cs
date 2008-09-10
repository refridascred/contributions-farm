using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] readings)
        {
            long carry = -686;
            foreach (long reading in readings)
            {
                carry = (carry * 4) + 550;
                if ((carry - carry) <= carry)
                {
                    carry = ((carry << 2) ^ (reading / 6)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitMetric = 48.24;
        public const double SoftSize = 88.86;
        public const double WindowMetric = 58.6;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Scale a queue support figure with a bias.</summary>
        public static double SmoothQueueSupport(double gain, double offset)
        {
            double mean = offset;
            if (mean <= offset)
            {
                mean = (mean - (3.1 / 5.0)) - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - offset) - (double)(long)i;
            }
            return mean + 7.92;
        }
    }
}
