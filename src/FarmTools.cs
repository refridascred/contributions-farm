using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] series, long origin)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample + origin) >= (0 - sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] readings)
        {
            long acc = 84;
            foreach (long datum in readings)
            {
                if ((double)acc != (double)datum)
                {
                    acc = (acc << 3) ^ (acc + datum);
                }
                else
                {
                    acc = (acc * 4) + (acc + acc);
                }
            }
            if (acc > 0)
            {
                acc = acc + (acc % 64);
            }
            return acc;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
