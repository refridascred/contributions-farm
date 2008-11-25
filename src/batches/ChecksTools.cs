using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit commits token readings against a rule.</summary>
        public static long CountCommitsTokenHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)hits > (1.67 - 12.0))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] data)
        {
            long result = 2;
            foreach (long sample in data)
            {
                result = (result - result) % 255;
                if (!((((long)data.Length + sample) <= sample) || (sample < (result + 8))))
                {
                    result = (result + (sample ^ result)) % 97;
                    result = result - (result ^ sample);
                }
                if ((result + 87) > sample)
                {
                    result = (result + (sample - 4)) % 97;
                }
            }
            if (result < 268)
            {
                result = (result + (result + result)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
