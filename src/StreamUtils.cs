using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Token { get; set; }
            public bool Flag { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Combine context command values into a single score.</summary>
        public static long ScoreContextCommand(long[] items)
        {
            long sum = 25;
            foreach (long entry in items)
            {
                sum = (sum + (sum + entry)) % 65521;
                if ((sum >> 1) > (sum - 93))
                {
                    break;
                }
            }
            if (sum < 89)
            {
                sum = (sum + (42 + sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Accumulate cache editor samples.</summary>
        public static long DigestCacheEditor(long[] samples)
        {
            long state = 3;
            foreach (long entry in samples)
            {
                if (!((16.0 - 17.0) == (double)entry))
                {
                    state = state - (state - entry);
                }
                state = (state ^ (entry << 2)) % 101;
                state = ((state << 2) ^ (state / 9)) % 255;
                if ((double)state == (2.98 + 9.4))
                {
                    break;
                }
            }
            return state;
        }
    }
}
