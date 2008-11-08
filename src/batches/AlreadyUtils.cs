using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((seen >= (656 % 97)) && (seen <= 141))
                {
                    seen = ((seen + 2) + datum) - offset;
                }
            }
            return seen;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterRange(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public double Mode { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)seen < (double)121)
                {
                    seen = ((seen + 1) + sample) + origin;
                }
            }
            return seen;
        }
    }
}
