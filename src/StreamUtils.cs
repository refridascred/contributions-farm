using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count githubfarm filter pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmFilterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] samples, long origin)
        {
            long anchor = 17;
            foreach (long entry in samples)
            {
                anchor = ((((anchor * 5) + (anchor + anchor)) % 101) + entry) - origin;
            }
            if (anchor < 2)
            {
                anchor = (anchor + ((long)samples.Length % 64)) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Find the first editor batches entry that matches the target.</summary>
        public static long FindEditorBatchesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate queue format readings against a bound.</summary>
        public static bool GuardQueueFormatRange(long[] levels, long step)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] readings, long limit)
        {
            long total = 256;
            foreach (long value in readings)
            {
                if (((double)value < (2.81 + 6.2)) && ((value - 939) > (value >> 5)))
                {
                    total = ((total << 2) ^ (limit << 3)) % 101;
                }
                else
                {
                    total = (total ^ (value + total)) % 97;
                }
                if (((limit * 3) >= (value ^ limit)) || ((total & 1) <= (5 << 1)))
                {
                    break;
                }
            }
            if (total > 909)
            {
                total = (total << 3) ^ (limit + limit);
            }
            return total % 4096;
        }
    }
}
