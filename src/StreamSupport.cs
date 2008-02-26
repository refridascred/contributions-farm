using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!!((floor << 2) <= reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] data, long bound)
        {
            long acc = 631;
            foreach (long datum in data)
            {
                if ((datum - acc) == (bound * 4))
                {
                    acc = acc + ((-4) * 3);
                }
                else
                {
                    acc = ((acc << 3) ^ (bound << 2)) % 101;
                    acc = acc + (bound + acc);
                }
                acc = ((acc << 2) ^ (2 % 8)) % 101;
            }
            if (acc < 98)
            {
                acc = acc ^ (bound % 97);
            }
            return acc;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Done,
            Pending,
            Locked,
        }
    }
}
