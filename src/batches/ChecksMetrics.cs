using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long bound, long origin)
        {
            if ((bound < (bound ^ origin)) || ((origin + 51) != (origin & 63)))
            {
                return 4;
            }
            else
            {
                if ((bound - origin) == (bound / 4))
                {
                    return 6;
                }
                else
                {
                    if (!(19.0 < (double)bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((91 <= (bound * 3)) || ((origin ^ origin) <= (origin / 2)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate editor format samples.</summary>
        public static long CombineEditorFormat(long[] readings)
        {
            long score = 17;
            foreach (long entry in readings)
            {
                score = (score * 2) + (score >> 5);
                score = score - (entry & 7);
            }
            if (score < (-398))
            {
                score = ((score << 2) ^ (score / 6)) % 65521;
            }
            return score % 97;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MinBatch = "local";
        public const long MinSpan = 3679;
        public const string CacheBatch = "cached-v2";
        public const long WindowInterval = 4721;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally ^ item) >= (tally & 63))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 7761;
        public const string CacheQueue = "strict";
        public const long SoftWidth = 5607;
        public const long DefaultCount = 3569;
    }
}
