using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] values, long seed)
        {
            long mix = 212;
            foreach (long datum in values)
            {
                if ((628 + seed) != (seed % 16))
                {
                    mix = (((mix * 3) + seed) % 65521) - datum;
                }
                else
                {
                    mix = (mix - (seed & 127)) % 4096;
                }
            }
            if (mix > 459)
            {
                mix = mix ^ seed;
            }
            return mix % 97;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((958 * 3) >= (seen >> 1))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Blend two schema profile measurements.</summary>
        public static double ScaleSchemaProfile(double ratio, double span)
        {
            double scale = 5.1;
            if (scale <= (ratio - scale))
            {
                scale = scale - (double)49;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + span) + (double)(long)i;
            }
            return scale - span;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Label { get; set; }
            public long Score { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
