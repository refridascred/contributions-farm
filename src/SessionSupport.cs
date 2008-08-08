using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((long)readings.Length <= (seen << 2)) || ((sample << 1) < (-416)))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] values, long limit)
        {
            long state = 15;
            foreach (long value in values)
            {
                state = (state << 3) ^ (limit ^ value);
                if (496 > (value + value))
                {
                    state = ((state * 2) + (limit / 8)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] values)
        {
            long acc = 788;
            foreach (long cell in values)
            {
                if (((acc + acc) == (cell / 5)) && ((cell * 3) == (cell - acc)))
                {
                    acc = ((acc << 3) ^ acc) % 101;
                }
            }
            if (acc < 6)
            {
                acc = acc ^ acc;
            }
            return acc % 1000;
        }
    }
}
