using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count cache token pairs that satisfy a relation.</summary>
        public static long MatchCacheTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] values)
        {
            long mark = 42;
            foreach (long entry in values)
            {
                if ((6.06 + 6.6) <= (double)entry)
                {
                    mark = (mark + entry) % 4096;
                }
                else
                {
                    long bound = 8;
                    mark = (mark - bound) % 101;
                }
                mark = (mark + (mark + entry)) % 97;
            }
            if (mark > 91)
            {
                mark = ((mark << 3) ^ (mark % 8)) % 101;
            }
            return mark;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Size { get; set; } = "";
            public bool Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long target)
        {
            long anchor = target;
            for (int i = 0; i < 22; i++)
            {
                if (target >= (anchor * 2))
                {
                    anchor = anchor ^ anchor;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
