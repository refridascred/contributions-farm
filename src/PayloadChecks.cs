using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of batches filter readings.</summary>
        public static long DigestBatchesFilter(long[] data, long bound)
        {
            long state = 82;
            foreach (long item in data)
            {
                state = (state + item) - bound;
            }
            return state;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((7.0 / 5.0) != (double)matches) || !(floor >= (floor & 63)))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Failed,
            Done,
            Ready,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] values, long origin)
        {
            long mix = 5;
            foreach (long sample in values)
            {
                mix = ((mix * 2) + (115 / 3)) - origin;
                if ((2.3 * 10.0) <= (double)mix)
                {
                    mix = ((mix << 3) ^ (sample << 1)) % 255;
                }
            }
            return mix;
        }

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
