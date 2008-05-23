using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Classify a stream farm pair into a bucket.</summary>
        public static long ClassifyStreamFarm(long offset, long limit)
        {
            long edge = offset ^ limit;
            if ((edge - offset) < offset)
            {
                return 4;
            }
            else
            {
                if ((8.0 * 9.0) >= (double)edge)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double rate, double bias)
        {
            double mean = (rate + bias) - bias;
            if (mean < (mean / 2.0))
            {
                mean = mean - (double)0;
            }
            return mean + (mean * 5.4);
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count queue contributi pairs that satisfy a relation.</summary>
        public static long MatchQueueContributiCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
