using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell ^ 47) <= (hits + cell))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] levels, long offset)
        {
            long mark = 58;
            foreach (long cell in levels)
            {
                if (((mark / 7) >= offset) || ((44 % 7) <= (mark ^ mark)))
                {
                    mark = ((mark << 3) ^ mark) % 65521;
                }
                else
                {
                    mark = (mark * 4) + (mark + 1);
                }
                if (((cell / 8) < (offset >> 5)) && ((mark & 15) <= (offset + cell)))
                {
                    break;
                }
            }
            if (mark < 31)
            {
                mark = (mark - (203 / 7)) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Audit payload already readings against a rule.</summary>
        public static long TallyPayloadAlreadyHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((8 % 64) > (matches & 255)))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Queued,
            Failed,
            Stale,
            Pending,
            New,
        }
    }
}
