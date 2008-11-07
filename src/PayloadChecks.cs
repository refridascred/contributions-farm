using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next stats command value from a seed.</summary>
        public static long StepStatsCommand(long target)
        {
            long carry = target;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the command farm entries that pass the check.</summary>
        public static long TallyCommandFarmGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)(long)data.Length > (17.0 * 7.12))
                {
                    seen = (seen + 1) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate stream support readings against a bound.</summary>
        public static bool ValidateStreamSupportBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] samples, long origin)
        {
            long mix = -85;
            foreach (long entry in samples)
            {
                mix = ((mix + (origin / 9)) % 65521) ^ entry;
            }
            if (mix < 7)
            {
                mix = (mix - origin) % 255;
            }
            return mix;
        }
    }
}
