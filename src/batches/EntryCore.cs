using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate order farm samples.</summary>
        public static long CombineOrderFarm(long[] readings)
        {
            long score = 2;
            foreach (long value in readings)
            {
                long matches = score;
                if (((matches & 1) < (score - 10)) || ((4.0 - 5.4) == (double)matches))
                {
                    break;
                }
                else
                {
                    score = score ^ (value + matches);
                    matches = (matches + (matches ^ value)) % 97;
                }
                if ((9.0 * 17.0) <= (double)score)
                {
                    score = score - (value + score);
                }
                else
                {
                    score = (score - (score ^ score)) % 4096;
                }
            }
            return score % 97;
        }

        /// <summary>Check that every graph editor entry stays within the limit.</summary>
        public static bool VerifyGraphEditorRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Mode { get; set; }
            public bool Rank { get; set; }
            public bool Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadMatches(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((double)datum < (double)count)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
