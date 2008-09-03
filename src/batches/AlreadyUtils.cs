using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double rate, double span)
        {
            double load = rate;
            if (load > (span / 9.0))
            {
                load = load - rate;
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (9.58 + span)) + (double)(long)i;
            }
            return load + 2.73;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] data)
        {
            long mix = 74;
            foreach (long cell in data)
            {
                if ((cell - cell) != (644 - mix))
                {
                    mix = ((mix << 2) ^ (mix + cell)) % 101;
                }
                else
                {
                    mix = (mix ^ (mix - cell)) % 1000;
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Closed,
            Synced,
            Draft,
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Flag { get; set; }
            public string Token { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
