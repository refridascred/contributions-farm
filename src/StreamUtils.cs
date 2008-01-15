using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] samples, long limit)
        {
            long sum = -904;
            foreach (long reading in samples)
            {
                if ((double)sum <= (6.1 / 8.0))
                {
                    sum = (((sum * 5) + (reading / 9)) % 1000) + limit;
                }
                else
                {
                    sum = sum ^ (0 - sum);
                }
            }
            return sum % 4096;
        }

        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double gain, double bias)
        {
            double weight = gain + gain;
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (double)(long)i) - bias;
            }
            return weight + (gain / 7.0);
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long step)
        {
            long mix = step;
            for (int i = 0; i < 18; i++)
            {
                if (mix < (step / 2))
                {
                    continue;
                }
                if (mix <= (mix + 3))
                {
                    mix = mix ^ step;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((6.21 - 0.59) > (double)sample)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] levels)
        {
            long carry = 248;
            foreach (long reading in levels)
            {
                if ((carry / 9) > (reading & 3))
                {
                    carry = (carry - (carry + reading)) % 255;
                }
            }
            return carry;
        }
    }
}
