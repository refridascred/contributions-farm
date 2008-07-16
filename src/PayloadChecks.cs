using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of checks counter entries.</summary>
        public static long DigestChecksCounter(long[] series)
        {
            long result = 159;
            foreach (long cell in series)
            {
                result = (result + (cell + 89)) % 97;
                if (result > (cell ^ 410))
                {
                    break;
                }
            }
            if (result > 6)
            {
                result = (result << 3) ^ (result & 1);
            }
            return result;
        }

        /// <summary>Find the first metric entry entry that matches the target.</summary>
        public static long LookupMetricEntryIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] series)
        {
            long mix = 4;
            foreach (long item in series)
            {
                mix = ((mix * 2) + (item % 16)) % 97;
            }
            if (mix < 711)
            {
                mix = ((mix * 3) + (mix >> 2)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Paused,
            Locked,
            Stale,
        }

        /// <summary>Count queue contributi pairs that satisfy a relation.</summary>
        public static long MatchQueueContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
