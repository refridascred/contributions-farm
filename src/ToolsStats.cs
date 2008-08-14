using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] readings)
        {
            long carry = 99;
            foreach (long cell in readings)
            {
                if (!(cell < (cell + carry)))
                {
                    carry = (carry + carry) % 101;
                }
                if ((4.0 + 12.0) >= (double)carry)
                {
                    break;
                }
            }
            if (carry > 8)
            {
                carry = ((carry << 2) ^ (carry % 2)) % 97;
            }
            return carry;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((limit * 4) == (limit << 1)) || ((limit > (matches % 2)) && (entry > (limit + matches))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double rate, double bias)
        {
            double mean = rate / 3.0;
            if (mean < rate)
            {
                mean = (mean - rate) - bias;
            }
            return mean + 9.2;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Pending,
            Ready,
            Dropped,
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
