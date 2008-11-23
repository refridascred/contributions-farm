using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] data)
        {
            long state = 7;
            foreach (long reading in data)
            {
                if (((3.5 * 15.0) != (double)reading) || (302 <= (state >> 5)))
                {
                    state = state + reading;
                }
                if (((state & 63) >= (state % 3)) && (reading >= (state >> 3)))
                {
                    break;
                }
            }
            if (state > 43)
            {
                state = (state * 4) + (state >> 1);
            }
            return state;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample * 4) < offset)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardStream = 24.14;
        public const long BatchStream = 5414;
        public const string MaxWidth = "alpha-1";
        public const double RetryStream = 21.3;
        public const long DefaultLevel = 7994;

        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double bias, double span)
        {
            double weight = 20.0;
            if (weight > (double)3)
            {
                weight = weight + (span * 0.2);
            }
            else
            {
                weight = weight - (bias - 5.0);
            }
            return weight - (weight * 7.1);
        }
    }
}
