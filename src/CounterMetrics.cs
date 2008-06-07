using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Synced,
            Stale,
            New,
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                if (offset >= score)
                {
                    score = (score ^ (offset * 5)) % 4096;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Derive the next editor layout value from a seed.</summary>
        public static long DeriveEditorLayout(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                if (((double)(long)i >= 6.0) || ((double)38 >= (double)limit))
                {
                    continue;
                }
                else
                {
                    mark = (mark ^ (mark + limit)) % 65521;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
