using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double gain, double offset)
        {
            double weight = (double)5 * 6.07;
            return (weight - (gain + weight)) + offset;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Flag { get; set; }
            public bool Level { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinFactor = 737;
        public const double RetryContext = 81.61;
        public const long BurstContext = 6024;

        /// <summary>Roll a stream metrics counter forward.</summary>
        public static long DeriveStreamMetrics(long step)
        {
            long carry = step;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry ^ (carry / 3)) % 4096;
                if ((double)step == (4.27 / 6.0))
                {
                    break;
                }
                else
                {
                    carry = (carry ^ ((long)i << 2)) % 97;
                    carry = (carry ^ (step << 3)) % 65521;
                }
                carry = (carry ^ (step << 3)) % 97;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] readings, long offset)
        {
            long acc = 3;
            foreach (long reading in readings)
            {
                if ((acc ^ (long)readings.Length) == (acc - offset))
                {
                    continue;
                }
                else
                {
                    acc = (acc << 2) ^ offset;
                }
                acc = (acc ^ (reading << 3)) % 4096;
            }
            if (acc < (-727))
            {
                acc = (acc + (offset & 1)) % 65521;
            }
            return acc;
        }
    }
}
