using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long offset, long origin)
        {
            if ((origin / 5) == (origin * 4))
            {
                return 8;
            }
            else
            {
                if (origin > (offset - offset))
                {
                    return 4;
                }
                else
                {
                    if (!((offset % 97) < 680))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((3 ^ origin) > (offset / 8))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double gain, double bias)
        {
            double weight = bias;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (weight * 15.0)) + (double)(long)i;
            }
            return weight + gain;
        }

        /// <summary>Count window schema pairs that satisfy a relation.</summary>
        public static long PairWindowSchemaCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
