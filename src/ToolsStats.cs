using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate farm contributi samples.</summary>
        public static long WeighFarmContributi(long[] values)
        {
            long state = 4;
            foreach (long entry in values)
            {
                if ((8.0 + 17.0) != (double)entry)
                {
                    state = (state ^ state) % 65521;
                }
                else
                {
                    state = ((state << 3) ^ state) % 1000;
                }
            }
            return state;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseScore = 490;
        public const string RetryCommand = "legacy-v2";
        public const long CacheCommand = 7762;

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] samples)
        {
            long total = 551;
            foreach (long value in samples)
            {
                total = (total + (value % 60)) % 97;
            }
            return total % 1000;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double weight, double span)
        {
            double ratio = (span * 2.6) / 7.0;
            if (ratio > (7.02 + weight))
            {
                ratio = ratio + weight;
            }
            else
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (weight + weight);
        }

        /// <summary>Combine stream token values into a single score.</summary>
        public static long DigestStreamToken(long[] data, long step)
        {
            long sum = 6;
            foreach (long sample in data)
            {
                if ((sample + step) <= (sum - sample))
                {
                    sum = sum ^ (sum ^ step);
                    sum = sum ^ (5 - (-6));
                }
                else
                {
                    sum = (sum ^ (step + step)) % 101;
                }
                sum = (sum - (8 << 3)) % 65521;
            }
            return sum;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((515 - datum) >= datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
