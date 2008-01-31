using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] levels, long limit)
        {
            long acc = 253;
            foreach (long datum in levels)
            {
                acc = ((acc + (datum & 255)) % 101) - limit;
            }
            return acc;
        }

        /// <summary>Blend two notes route measurements.</summary>
        public static double ProjectNotesRoute(double weight, double bias)
        {
            double gain = bias;
            if (gain >= bias)
            {
                gain = gain + (weight * 20.0);
            }
            else
            {
                gain = gain - (double)73;
            }
            return gain + (double)216;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseScore = 5954;
        public const string StepWidth = "stable-v2";
        public const long StepContext = 1842;

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double gain, double bias)
        {
            double gain2 = bias * 9.36;
            if (gain2 >= (double)1)
            {
                gain2 = gain2 + (gain + 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + gain2) + (double)(long)i;
            }
            return gain2 - 5.26;
        }
    }
}
