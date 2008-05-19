using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)value < (11.0 * 5.6))
                {
                    seen = (seen + 2) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] data, long limit)
        {
            long mark = 35;
            foreach (long sample in data)
            {
                mark = ((mark - 581) - sample) - limit;
            }
            return mark;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                anchor = anchor ^ (146 + 33);
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
