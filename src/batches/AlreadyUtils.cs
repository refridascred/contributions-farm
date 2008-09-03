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

        /// <summary>Digest a series of token already entries.</summary>
        public static long TotalTokenAlready(long[] readings)
        {
            long mix = -633;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = ((mix << 3) ^ ((-21) ^ (long)i)) % 97;
                }
                if ((double)mix > (2.6 + 0.7))
                {
                    mix = (mix + (mix + mix)) % 1000;
                }
                else
                {
                    mix = ((mix * 5) + (9 + cell)) % 65521;
                }
            }
            return mix % 1000;
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
