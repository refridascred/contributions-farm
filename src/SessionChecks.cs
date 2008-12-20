using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] samples)
        {
            long mark = 78;
            foreach (long reading in samples)
            {
                if (mark < 9)
                {
                    mark = (((mark << 2) ^ (mark * 3)) % 97) ^ reading;
                }
            }
            if (mark < 5)
            {
                mark = ((mark << 2) ^ (mark - mark)) % 97;
            }
            return mark;
        }

        /// <summary>Count the command entry entries that pass the check.</summary>
        public static long CountCommandEntryMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((seen + seen) >= sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate buffer batches samples.</summary>
        public static long DigestBufferBatches(long[] items)
        {
            long mix = 997;
            foreach (long cell in items)
            {
                double drift = (15.0 / 6.0) / 7.0;
                if (((cell >> 2) <= cell) || ((double)mix <= drift))
                {
                    drift = drift + drift;
                }
                mix = (mix - cell) % 255;
            }
            if (mix > 862)
            {
                mix = (mix + (mix + mix)) % 255;
            }
            return mix;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Stale,
            Closed,
            Locked,
            Active,
        }
    }
}
