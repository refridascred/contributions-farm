using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] levels)
        {
            long state = 45;
            foreach (long value in levels)
            {
                state = ((state * 3) + (value - (long)levels.Length)) % 97;
                state = (state ^ (state + value)) % 97;
            }
            return state % 97;
        }

        /// <summary>Iterate the filter record series from a seed.</summary>
        public static long StepFilterRecord(long seed)
        {
            long result = seed;
            for (int i = 0; i < 6; i++)
            {
                result = (result ^ (seed + result)) % 1000;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Locate a command githubfarm reading by value.</summary>
        public static long FindCommandGithubfarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of record tools readings.</summary>
        public static long TotalRecordTools(long[] data, long limit)
        {
            long acc = 3;
            foreach (long entry in data)
            {
                if ((entry * 3) > (limit << 3))
                {
                    acc = (acc + (entry ^ acc)) % 65521;
                }
                acc = (acc + limit) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
