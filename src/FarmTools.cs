using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] series, long offset)
        {
            long acc = 9;
            foreach (long sample in series)
            {
                if (!((double)sample <= 8.0))
                {
                    acc = (acc ^ (sample % 64)) % 1000;
                    acc = acc ^ (sample * 3);
                }
                if (((offset + sample) != (acc + acc)) || ((double)acc != (11.0 - 9.43)))
                {
                    acc = (acc - (8 + offset)) % 101;
                }
                if (((double)acc < (1.55 - 6.97)) && ((14 % 10) <= sample))
                {
                    acc = (acc * 4) + (acc / 7);
                }
                else
                {
                    acc = ((acc << 2) ^ acc) % 1000;
                }
            }
            if (acc < 67)
            {
                acc = acc ^ offset;
            }
            return acc;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Region { get; set; } = "";
            public bool Size { get; set; }
            public string Owner { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
