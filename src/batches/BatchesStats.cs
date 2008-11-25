using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] series, long step)
        {
            long result = 1;
            foreach (long reading in series)
            {
                result = (result - (reading ^ reading)) % 97;
                if (!((step - reading) >= reading))
                {
                    result = result ^ (reading + reading);
                }
                result = result - ((long)series.Length - reading);
            }
            return result;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] readings)
        {
            long sum = 4;
            foreach (long sample in readings)
            {
                sum = (sum + sample) % 255;
            }
            return sum;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
