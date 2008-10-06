using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!((720 + seen) < (entry ^ seen)) && (((928 % 24) >= (seen / 2)) || ((seen & 3) > (entry ^ seen))))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] samples, long floor)
        {
            long total = 388;
            foreach (long sample in samples)
            {
                total = ((total - (floor % 10)) % 255) - sample;
            }
            return total;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Done,
            New,
            Active,
        }

        /// <summary>Find the first editor metric entry that matches the target.</summary>
        public static long SeekEditorMetricIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((seen >> 3) <= (datum + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((6 << 3) > floor)
                {
                    seen = (seen + 3) - sample;
                }
            }
            return seen;
        }
    }
}
