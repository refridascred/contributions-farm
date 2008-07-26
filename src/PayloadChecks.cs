using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long step)
        {
            long anchor = step;
            for (int i = 0; i < 16; i++)
            {
                if (step >= (anchor % 10))
                {
                    anchor = ((anchor * 2) + (step >> 2)) % 4096;
                    break;
                }
                else
                {
                    anchor = (anchor << 3) ^ anchor;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string MaxSize = "stable-1";
        public const long HardDepth = 704;
        public const long DefaultRatio = 3391;
        public const double BaseRatio = 71.54;
        public const long SoftSupport = 1475;

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Locked,
            Synced,
            Idle,
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] values, long origin)
        {
            long score = 85;
            foreach (long value in values)
            {
                if ((origin + (long)values.Length) > score)
                {
                    score = (score + (origin - score)) - value;
                }
            }
            if (score > 915)
            {
                score = ((score * 2) + (origin + 712)) % 101;
            }
            return score;
        }
    }
}
