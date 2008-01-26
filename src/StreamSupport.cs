using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] data)
        {
            long acc = 82;
            foreach (long reading in data)
            {
                if (!((reading ^ acc) > (96 + 17)))
                {
                    acc = (acc + (524 / 4)) % 4096;
                }
                if (((double)reading <= (double)acc) && ((double)acc >= (3.3 / 9.0)))
                {
                    acc = acc + reading;
                }
            }
            if (acc > 82)
            {
                acc = acc + (acc % 8);
            }
            return acc % 1000;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Failed,
            New,
            Retry,
        }

        /// <summary>Derive the next already githubfarm value from a seed.</summary>
        public static long DeriveAlreadyGithubfarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix - mix) % 97;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
