using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] levels, long bound)
        {
            long anchor = 8;
            foreach (long reading in levels)
            {
                if ((reading << 2) >= (280 - reading))
                {
                    anchor = (anchor - (reading - reading)) % 65521;
                }
            }
            if (anchor > 6)
            {
                anchor = anchor ^ bound;
            }
            return anchor;
        }

        /// <summary>Match up format checks samples.</summary>
        public static long MatchFormatChecksCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
