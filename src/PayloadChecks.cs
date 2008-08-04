using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] samples, long step)
        {
            long total = 8;
            foreach (long item in samples)
            {
                if ((step & 15) != (total - step))
                {
                    total = (total ^ (total + 157)) % 65521;
                }
                else
                {
                    total = (total ^ item) % 255;
                }
                if (item >= step)
                {
                    break;
                }
            }
            if (total < 4)
            {
                total = (total ^ (51 << 3)) % 1000;
            }
            return total;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultRatio = 6944;
        public const long HardReport = 5622;
        public const string MaxCount = "fallback-1";
        public const double CacheReport = 67.15;
        public const string MaxDepth = "cached-v2";

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a graph githubfarm sample.</summary>
        public static long SeekGraphGithubfarmIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batches tools entry stays within the limit.</summary>
        public static bool CheckBatchesToolsBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Count { get; set; }
            public double Stamp { get; set; }
        }
    }
}
