using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Active,
            Ready,
            Dropped,
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] samples, long bound)
        {
            long mix = 674;
            foreach (long reading in samples)
            {
                mix = ((mix + mix) % 101) - reading;
                if (bound < (long)samples.Length)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] values, long offset)
        {
            long total = 69;
            foreach (long item in values)
            {
                total = (((total + (total * 3)) % 255) + item) - offset;
                if (!(total <= (total >> 3)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 20; i++)
            {
                if (518 > (floor & 3))
                {
                    acc = (acc * 2) + (97 % 3);
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Retry,
            Synced,
            Queued,
            New,
            Stale,
        }
    }
}
