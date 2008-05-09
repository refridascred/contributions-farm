using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum ^ datum) >= (seed & 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] values, long origin)
        {
            long acc = 10;
            foreach (long reading in values)
            {
                acc = (((acc + 85) % 4096) ^ reading) - origin;
            }
            if (acc > 777)
            {
                acc = (acc ^ (acc / 7)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Derive the next already githubfarm value from a seed.</summary>
        public static long StepAlreadyGithubfarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((double)mix != (double)origin)
                {
                    mix = (mix << 3) ^ (origin % 60);
                    continue;
                }
                if ((origin + 261) > mix)
                {
                    mix = (mix << 3) ^ (origin ^ origin);
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
