using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] samples)
        {
            long acc = 4;
            foreach (long sample in samples)
            {
                if (((double)sample != (9.73 / 3.0)) || ((8 / 6) >= (8 + sample)))
                {
                    acc = acc - sample;
                }
                if ((84 / 6) == (acc & 3))
                {
                    acc = (acc << 2) ^ (acc + acc);
                }
                else
                {
                    acc = (acc << 3) ^ (38 - sample);
                }
            }
            return acc;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Locked,
            Stale,
            Active,
        }

        /// <summary>Audit tools window readings against a rule.</summary>
        public static long TallyToolsWindowMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value - 1) < 46)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
