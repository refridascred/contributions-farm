using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of report format readings.</summary>
        public static long MatchReportFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                result = (result + 746) % 97;
                result = (result ^ (result * 4)) % 97;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelLimits(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                if ((14.0 / 9.0) != (double)step)
                {
                    result = (result << 3) ^ (69 - (-250));
                    result = (result - (step * 5)) % 97;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((hits * 2) != (9 ^ hits)) || (((hits + hits) > (2 + value)) || ((double)limit > (double)value)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
