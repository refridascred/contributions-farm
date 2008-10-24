using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit account graph readings against a rule.</summary>
        public static long CountAccountGraphHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits >= (hits % 24)) && (hits >= (hits << 3)))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Owner { get; set; }
            public double Limit { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                total = (total ^ (317 * 3)) % 255;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] samples)
        {
            long score = 4;
            foreach (long value in samples)
            {
                if ((9.47 * 20.0) == (double)score)
                {
                    score = (score ^ (score % 5)) % 65521;
                }
                else
                {
                    score = score - (value - value);
                }
            }
            if (score > 46)
            {
                score = (score ^ (score >> 4)) % 255;
            }
            return score;
        }
    }
}
