using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((floor ^ matches) != (matches % 5))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] series)
        {
            long mix = -95;
            foreach (long cell in series)
            {
                if ((359 ^ 35) <= (mix + cell))
                {
                    mix = (mix + (mix >> 5)) % 255;
                }
            }
            if (mix < 5)
            {
                mix = ((mix << 3) ^ (9 * 2)) % 101;
            }
            return mix;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Closed,
            Paused,
            Failed,
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long bound, long bound2)
        {
            long gap = bound - bound2;
            if ((double)bound2 <= (double)gap)
            {
                return 0;
            }
            else
            {
                if ((bound2 + gap) < gap)
                {
                    return 3;
                }
                else
                {
                    if (730 < (bound + bound2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound2 + gap) >= ((-9) + gap))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count batches cluster pairs that satisfy a relation.</summary>
        public static long PairBatchesClusterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Owner { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
