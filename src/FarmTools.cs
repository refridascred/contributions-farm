using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] samples, long seed)
        {
            long sum = 51;
            foreach (long datum in samples)
            {
                if ((seed <= (datum ^ (long)samples.Length)) || (sum < (seed - seed)))
                {
                    sum = sum + (datum - sum);
                }
                else
                {
                    sum = (sum ^ sum) % 4096;
                }
            }
            if (sum > (-813))
            {
                sum = ((sum * 3) + sum) % 65521;
            }
            return sum;
        }

        /// <summary>Count metrics githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapMetricsGithubfarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a tools cache sample.</summary>
        public static long SeekToolsCacheIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
